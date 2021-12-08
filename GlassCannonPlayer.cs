using System;
using Terraria.ModLoader;

namespace GlassCannonMod
{
	public class GlassCannonPlayer : ModPlayer
	{
        public double damageBuff;
        public double healthNerf;
        public override void ResetEffects()
        {
            if (healthNerf == 1)
            {
                Player.statLifeMax2 -= (Player.statLifeMax2 - 1);
                //Player.statLifeMax2 = 0;
            }
            else
            {
                Player.statLifeMax2 -= (int)(Player.statLifeMax2 * healthNerf);
                //Player.statLifeMax2 -= (int)(Player.statLifeMax2 * healthNerf);
            } 
        }
        public override void PostUpdate()
        {

        }

        public override void Initialize()
        {
            //Health Impact
            switch (ModContent.GetInstance<GlassCannonConfig>().statImpact)
            {
                case 1:
                    healthNerf = .20;
                    break;
                case 2:
                    healthNerf = .40;
                    break;
                case 3:
                    healthNerf = .60;
                    break;
                case 4:
                    healthNerf = .80;
                    break;
                case 5:
                    healthNerf = 1;
                    break;
            }

            //Damage Impact
            if (ModContent.GetInstance<GlassCannonConfig>().damageBuffEnabled)
            {
                switch (ModContent.GetInstance<GlassCannonConfig>().statImpact)
                {
                    case 1:
                        damageBuff = 1.25;
                        break;
                    case 2:
                        damageBuff = 1.6;
                        break;
                    case 3:
                        damageBuff = 2;
                        break;
                    case 4:
                        damageBuff = 2.5;
                        break;
                    case 5:
                        damageBuff = 3;
                        break;
                }
            }
            else
            {
                damageBuff = 1;
            }
        }
    }
}