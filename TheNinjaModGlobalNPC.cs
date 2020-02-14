using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace TheNinjaMod
{

	public class TheNinjaModGlobalNPC : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{

			if (npc.type == NPCID.KingSlime)
			{
				if (Main.rand.NextBool(8))
				{
					Item.NewItem(npc.getRect(), mod.ItemType("SlimyKatana"));
				}
			}
		}
	}
}

