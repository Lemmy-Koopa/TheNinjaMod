using Terraria.ModLoader;
using Terraria.ID;

namespace TheNinjaMod.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class NinjaJeans : NinjaClassItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("NinjaJacket");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.defense = 3;
			item.value = 25000;
			item.crit = 2;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 2);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}