
using TheNinjaMod.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace TheNinjaMod.Items.Shuriken
{
	public class WoodenShuriken : NinjaClassItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("This Shuriken must've taken a while to carve out");

		}
		public override void SetDefaults()
		{			
			item.shootSpeed = 10f;
			item.damage = 5;
			item.knockBack = 6f;
			item.useStyle = 1;
			item.useAnimation = 19;
			item.useTime = 19;
			item.width = 32;
			item.height = 32;
			item.maxStack = 999;
			item.rare = 5;
			item.crit = 16;
			item.consumable = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.autoReuse = false;
			item.thrown = true;
			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(copper: 10);			
			item.shoot = ProjectileType<WoodenShurikenProjectile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 5);
			recipe.AddRecipe();
		}


	}
}