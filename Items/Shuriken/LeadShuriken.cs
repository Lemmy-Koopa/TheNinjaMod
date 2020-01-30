using TheNinjaMod.Projectiles.Shuriken;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace TheNinjaMod.Items.Shuriken
{
	public class LeadShuriken : NinjaClassItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Don’t cut yourself");

		}
		public override void SetDefaults()
		{
			item.shootSpeed = 10f;
			item.damage = 5;
			item.knockBack = 7f;
			item.useStyle = 1;
			item.useAnimation = 18;
			item.useTime = 18;
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
			item.value = Item.sellPrice(copper: 25);
			item.shoot = ProjectileType<LeadShurikenProjectile>();
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LeadBar, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 5);
			recipe.AddRecipe();
		}



	}
}