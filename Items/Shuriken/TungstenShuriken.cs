using TheNinjaMod.Projectiles.Shuriken;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace TheNinjaMod.Items.Shuriken
{
	public class TungstenShuriken : NinjaClassItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Don’t cut yourself");

		}
		public override void SetDefaults()
		{
			item.shootSpeed = 12f;
			item.damage = 8;
			item.knockBack = 7f;
			item.useStyle = 1;
			item.useAnimation = 17;
			item.useTime = 17;
			item.width = 32;
			item.height = 32;
			item.maxStack = 999;
			item.crit = 19;
			item.rare = 5;
			item.consumable = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.autoReuse = false;
			item.thrown = true;
			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(copper: 20);
			item.shoot = ProjectileType<TungstenShurikenProjectile>();
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TungstenBar, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 15);
			recipe.AddRecipe();
		}



	}
}