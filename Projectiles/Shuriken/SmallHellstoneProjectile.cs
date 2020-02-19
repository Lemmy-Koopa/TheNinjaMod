using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using TheNinjaMod.Projectiles;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System;


namespace TheNinjaMod.Projectiles.Shuriken
{
	public class SmallHellstoneProjectile : ModProjectile
	{
		public override void SetStaticDefaults()

		{
			DisplayName.SetDefault("SmallHellstoneProjectile");
		}

		public override void SetDefaults()
		{
			projectile.width = 32;
			projectile.height = 32;
			projectile.friendly = true;
			projectile.melee = true;
			projectile.penetrate = 3;
			projectile.aiStyle = 14;
			projectile.tileCollide = true;
			projectile.timeLeft = 180;
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			{
				target.AddBuff(BuffID.OnFire, 60);
			}
		}
	}
}

