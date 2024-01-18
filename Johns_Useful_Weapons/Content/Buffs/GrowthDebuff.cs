using Johns_Useful_Weapons.Common.GlobalNPCs;
using Terraria;
using Terraria.ModLoader;
namespace Johns_Useful_Weapons.Content.Buffs 
{
    public class GrowthDebuff : ModBuff
    {
        public float growthMultiplier = 1.25f;
        public override void SetStaticDefaults() {
            Main.pvpBuff[Type] = false;
        }   

        public override void Update(NPC npc, ref int buffIndex) {
            npc.GetGlobalNPC<DamageModificationGlobalNPCs>().growthDebuff = true;
            if (npc.width < 400) {
                npc.width = (int)(npc.width * growthMultiplier);
                npc.height = (int)(npc.height * growthMultiplier);
                npc.scale = npc.scale * growthMultiplier;
            }
        }
    }
}