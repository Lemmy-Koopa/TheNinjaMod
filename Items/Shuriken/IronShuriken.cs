
using TheNinjaMod.Projectiles.Shuriken;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace TheNinjaMod.Items.Shuriken
{
	public class IronShuriken : NinjaClassItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Don’t cut yourself");

		}
		public override void SetDefaults()
		{
			item.shootSpeed = 10f;
			item.damage = 4;
			item.knockBack = 6f;
			item.useStyle = 1;
			item.useAnimation = 19;
			item.useTime = 19;
			item.width = 32;
			item.height = 32;
			item.maxStack = 999;
			item.crit = 16;
			item.rare = 5;
			item.consumable = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.autoReuse = false;
			item.thrown = true;
			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(copper: 20);
			item.shoot = ProjectileType<IronShurikenProjectile>();
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 5);
			recipe.AddRecipe();
		}



	}
}