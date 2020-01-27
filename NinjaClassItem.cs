using Terraria;
using Terraria.ModLoader;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TheNinjaMod
{

    public abstract class NinjaClassItem : ModItem
    {
        public static bool assassin = true;

        public override void SetDefaults()
        {
            item.melee = false;
            item.ranged = false;
            item.magic = false;
            item.summon = false;
            item.thrown = false;
        }

        public virtual void SafeSetDefaults()
        {

        }

        public override void ModifyWeaponDamage(Player player, ref float add, ref float mult, ref float flat)
        {
            add += TheNinjaModPlayer.ModPlayer(player).AssassinDamageAdd;
            mult *= TheNinjaModPlayer.ModPlayer(player).AssassinDamageMult;
        }

        public override void GetWeaponKnockback(Player player, ref float knockback)
        {
            // Adds knockback bonuses
            knockback += TheNinjaModPlayer.ModPlayer(player).AssassinKnockback;
        }

        public override void GetWeaponCrit(Player player, ref int crit)
        {
            // Adds crit bonuses
            crit += TheNinjaModPlayer.ModPlayer(player).AssassinCrit;
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            var tt = tooltips.FirstOrDefault(x => x.Name == "Damage" && x.mod == "Terraria");
            if (tt != null)
            {
                string[] split = tt.text.Split(' ');
                tt.text = split.First() + " Assassin " + split.Last();
            }
        }

        

    }

}
