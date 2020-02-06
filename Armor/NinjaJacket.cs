using Terraria.ModLoader;
using Terraria.ID;

namespace TheNinjaMod.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class NinjaJacket : NinjaClassItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("NinjaJacket");
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 30;
			item.defense = 3;
			item.value = 25000;
			item.crit = 2;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 4);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}