using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;



namespace TheNinjaMod
{
    public class TheNinjaModPlayer : ModPlayer
    {

        public static TheNinjaModPlayer ModPlayer(Player player)
        {
            return player.GetModPlayer<TheNinjaModPlayer>();
        }

        public float AssassinDamageAdd;
        public float AssassinDamageMult = 1f;
        public float AssassinKnockback;
        public int AssassinCrit;

        public int AssassinResourceCurrent;
        public const int DefaultAssassinMax = 100;
        public int AssassinResourceMax;
        public int AssassinResourceMax2;
        public float AssassinResourceRegenRate;
        internal int AssassinResourceRegenTimer = 0;
        public static readonly Color HealAssassinResource = new Color(187, 91, 201); // We can use this for CombatText, if you create an item that replenishes exampleResourceCurrent.




        public float AssassinDamage = 1f;
        public override void ResetEffects()
        {
            AssassinDamage = 1f;
        }

        
    }
}