using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using TheNinjaMod.Projectiles;
using System.Collections.Generic;


namespace TheNinjaMod.Projectiles.Shuriken
{
	public class WaterShurikenProjectile : ModProjectile
	{
		int Bounces;
		bool Washed;
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("WaterShurikenProjectile");
		}

		public override void SetDefaults()
		{
			projectile.width = 20;
			projectile.height = 20;
			projectile.friendly = true;
			projectile.melee = true;
			projectile.penetrate = 4;
			projectile.aiStyle = 2;			
			Bounces = 2;
			Washed = false;
		}



		public override void Kill(int timeLeft)
		{
			{
				Vector2 rotVector = (projectile.rotation - MathHelper.ToRadians(90f)).ToRotationVector2(); // rotation vector to use for dust velocity
				_ = rotVector * 16f;

				Main.PlaySound(0, (int)projectile.position.X, (int)projectile.position.Y);
				Vector2 usePos = projectile.position;
				Collision.HitTiles(projectile.position, projectile.velocity, projectile.width, projectile.height);

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
		}
		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			if (Bounces > 0)
			{
				Collision.HitTiles(projectile.position + projectile.velocity, projectile.velocity, projectile.width, projectile.height);
				Main.PlaySound(SoundID.Item21, projectile.position);
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





