using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TheNinjaMod.Projectiles.Shuriken;
using static Terraria.ModLoader.ModContent;

namespace TheNinjaMod.Items.Shuriken
{
	public class PlatinumShuriken : NinjaClassItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Don’t cut yourself");

		}
		public override void SetDefaults()
		{
			item.shootSpeed = 14f;
			item.damage = 10;
			item.knockBack = 7f;
			item.useStyle = 1;
			item.useAnimation = 17;
			item.useTime = 17;
			item.width = 32;
			item.height = 32;
			item.maxStack = 999;
			item.crit = 24;
			item.rare = 5;
			item.consumable = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.autoReuse = false;
			item.thrown = true;
			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(copper: 20);
			item.shoot = ProjectileType<PlatinumShurikenProjectile>();
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumBar, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 20);
			recipe.AddRecipe();
		}



	}
}