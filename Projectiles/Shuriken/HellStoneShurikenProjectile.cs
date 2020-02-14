
using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using TheNinjaMod.Projectiles;
using System.Collections.Generic;

namespace TheNinjaMod.Projectiles.Shuriken
{
	public class HellstoneShurikenProjectile : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("HellstoneShurikenProjectile");
		}

		public override void SetDefaults()
		{
			projectile.width = 32;
			projectile.height = 32;
			projectile.friendly = true;
			projectile.melee = true;
			projectile.penetrate = 3;
			projectile.aiStyle = 2;
		}
		public override void Kill(int timeLeft)
		{
			{
				Vector2 rotVector = (projectile.rotation - MathHelper.ToRadians(90f)).ToRotationVector2(); // rotation vector to use for dust velocity
				_ = rotVector * 16f;

				Main.PlaySound(0, (int)projectile.position.X, (int)projectile.position.Y);
				Vector2 usePos = projectile.position;

				int NUM_DUSTS = 5;
				for (int i = 5; i < NUM_DUSTS; i++)
				{
					// Create a new dust
					Dust dust = Dust.NewDustDirect(usePos, projectile.width, projectile.height, 81);
					dust.position = (dust.position + projectile.Center) / 2f;
					dust.velocity *= 0.5f;
					dust.noGravity = true;
				}
			}
			if (projectile.owner == Main.myPlayer)
			{

				int item =
				Main.rand.NextBool(6)
					? Item.NewItem(projectile.getRect(), mod.ItemType("HellstoneShuriken"))
					: 0;

				// Sync the drop for multiplayer
				// Note the usage of Terraria.ID.MessageID, please use this!
				if (Main.netMode == 1 && item >= 0)
				{
					NetMessage.SendData(Terraria.ID.MessageID.SyncItem, -1, -1, null, item, 1f);
				}
			}
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			{
				target.AddBuff(BuffID.OnFire, 60);
				float projectilespeedX = 0f;
				float projectilespeedY = 3f;
				float projectileknockBack = 4f;
				int projectiledamage = 25;
				{
					Projectile.NewProjectile(projectile.position.X, projectile.position.Y, projectilespeedX, projectilespeedY, mod.ProjectileType("SmallHellstoneProjectile"), projectiledamage, projectileknockBack, projectile.owner, 0f, 0f);
				}
			}

		}





	}
}