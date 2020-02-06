using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TheNinjaMod.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class NinjaHood : NinjaClassItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("NinjaHood");
		}

		public override void SetDefaults()
		{
			item.width = 5;
			item.height = 19;
			item.defense = 2;
			item.value = 2000;
		}
		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<NinjaJacket>() && legs.type == ModContent.ItemType<NinjaJeans>();
		}
		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "2% extra Assassin crit damage";
			player.GetModPlayer<TheNinjaModPlayer>().AssassinCrit += 2;
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