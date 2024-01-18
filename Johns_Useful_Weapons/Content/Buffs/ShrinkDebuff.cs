using Johns_Useful_Weapons.Common.GlobalNPCs;
using Terraria;
using Terraria.ModLoader;

namespace Johns_Useful_Weapons.Content.Buffs 
{
    public class ShrinkDebuff : ModBuff
    {
        public float shrinkMultiplier = 0.7f;
        public override void SetStaticDefaults() {
            Main.pvpBuff[Type] = false;
        }   

        public override void Update(NPC npc, ref int buffIndex) {
            npc.GetGlobalNPC<DamageModificationGlobalNPCs>().shrinkDebuff = true;
            if (npc.width > 4) {
                npc.width = (int)(npc.width * shrinkMultiplier);
                npc.height = (int)(npc.height * shrinkMultiplier);
                npc.scale = npc.scale * shrinkMultiplier;
            }
        }  
    }
}