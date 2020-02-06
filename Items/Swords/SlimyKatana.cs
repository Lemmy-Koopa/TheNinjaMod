using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria;

namespace TheNinjaMod.Items.Swords
{
	public class SlimyKatana : NinjaClassItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Eww! It's so Slimy.");
		}

		public override void SetDefaults()
		{
			item.damage = 12;
			item.melee = false;
			item.width = 40;
			item.height = 40;
			item.useTime = 17;
			item.useAnimation = 17;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.crit = 25;
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{			
			target.AddBuff(BuffID.Slimed, 60);
		}
	}
}
