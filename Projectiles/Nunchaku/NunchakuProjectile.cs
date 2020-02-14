using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using TheNinjaMod.Projectiles;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System;
using Microsoft.Xna.Framework.Graphics;

namespace TheNinjaMod.Projectiles.Nunchaku
{
	public class NunchakuProjectile : ModProjectile
	{
		public override void SetStaticDefaults()

		{
			DisplayName.SetDefault("NunchakuProjectile");
		}

		public override void SetDefaults()
		{
			projectile.width = 32;
			projectile.height = 32;
			projectile.friendly = true;
			projectile.melee = true;
			projectile.penetrate = 3;
			projectile.aiStyle = 2;
			projectile.tileCollide = false;
			projectile.timeLeft = 180;
		}

		public override void AI()
		{
			Player player = Main.player[projectile.owner];

			double distance = 60; //how far the projectile circle is from the player
			double degree = (double)projectile.ai[1] + (12 * projectile.ai[0]);
			double radius = degree * (Math.PI / 180);//Degree

			projectile.position.X = player.Center.X - (int)(Math.Cos(radius) * distance) - projectile.width / 2;
			projectile.position.Y = player.Center.Y - (int)(Math.Sin(radius) * distance) - projectile.height / 2;
			projectile.ai[1] += 1f; // How fast it circles the player

		}
		
	}
}


