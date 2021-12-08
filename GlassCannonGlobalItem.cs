using Terraria;
using Terraria.ModLoader;

namespace GlassCannonMod
{
	public class GlassCannonGlobalitem : GlobalItem
	{
        public override void ModifyWeaponDamage(Item item, Player player, ref StatModifier damage, ref float flat)
        {
            damage = new StatModifier(1, (float)player.GetModPlayer<GlassCannonPlayer>().damageBuff);
        }
    }
}