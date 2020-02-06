
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TheNinjaMod;

namespace TheNinjaMod.Accessories
{
	public class NinjaEmblem : NinjaClassItem
	{

		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("15% increased Assassin damage");

		}

		public override void SetDefaults()
		{
			item.Size = new Vector2(34);
			item.rare = 4;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			TheNinjaModPlayer modPlayer = player.GetModPlayer<TheNinjaModPlayer>();
			modPlayer.AssassinDamageAdd += 0.15f;
		}

		public class WofBagDrop : GlobalItem
		{

			public override void OpenVanillaBag(string context, Player player, int arg)
			{
				if (context == "bossBag" && arg == ItemID.WallOfFleshBossBag && Main.rand.Next(4) == 0)
				{
					player.QuickSpawnItem(mod.ItemType("NinjaEmblem"));
				}
			}
		}
	}
}