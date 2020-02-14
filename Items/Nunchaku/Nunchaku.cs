using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TheNinjaMod.Projectiles.Nunchaku;

namespace TheNinjaMod.Items.Nunchaku
{
	public class Nunchaku : NinjaClassItem
	{
		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 10;
			item.value = Item.sellPrice(silver: 5);
			item.rare = ItemRarityID.White;
			item.noMelee = true;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.useAnimation = 40;
			item.useTime = 40;
			item.knockBack = 9f;
			item.damage = 14;
			item.scale = 2f;
			item.noUseGraphic = true;
			item.shoot = ModContent.ProjectileType<NunchakuProjectile>();
			item.shootSpeed = 20f;
			item.UseSound = SoundID.Item1;
			item.melee = true;
			item.crit = 9;
			
		}
	}
}
