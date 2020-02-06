﻿using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using TheNinjaMod.Projectiles;
using System.Collections.Generic;

namespace TheNinjaMod.Projectiles.Shuriken
{
	
	public class SlimyShurikenProjectile : ModProjectile
	{
		int Bounces;
		bool Washed;
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("SlimyShurikenProjectile");
		}

		public override void SetDefaults()
		{
			projectile.width = 22;
			projectile.height = 22;
			projectile.friendly = true;
			projectile.melee = true;
			projectile.penetrate = 5;
			projectile.aiStyle = 2;
			Bounces = 2;
			Washed = false;
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(BuffID.Bleeding, 120);
		}

		public override void Kill(int timeLeft)
		{
			{
				Main.PlaySound(0, (int)projectile.position.X, (int)projectile.position.Y);
				Vector2 usePos = projectile.position;

				projectile.spriteDirection = projectile.direction = (projectile.velocity.X > 0).ToDirectionInt();

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
					? Item.NewItem(projectile.getRect(), mod.ItemType("SilmyShuriken"))
					: 0;

				// Sync the drop for multiplayer
				// Note the usage of Terraria.ID.MessageID, please use this!
				if (Main.netMode == 1 && item >= 0)
				{
					NetMessage.SendData(Terraria.ID.MessageID.SyncItem, -1, -1, null, item, 1f);
				}
			}
		}
		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			if (Bounces > 0)
			{
				Collision.HitTiles(projectile.position + projectile.velocity, projectile.velocity, projectile.width, projectile.height);
				Main.PlaySound(SoundID.Item56, projectile.position);
				if (projectile.velocity.X != oldVelocity.X)
				{
					projectile.velocity.X = -oldVelocity.X;
				}
				if (projectile.velocity.Y != oldVelocity.Y)
				{
					projectile.velocity.Y = -oldVelocity.Y;
				}
				projectile.penetrate -= 1;
				Bounces -= 1;
				return false;
			}
			return base.OnTileCollide(oldVelocity);
		}



	}
}