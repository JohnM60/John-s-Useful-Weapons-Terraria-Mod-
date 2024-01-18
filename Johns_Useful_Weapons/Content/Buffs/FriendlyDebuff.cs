using Johns_Useful_Weapons.Common.GlobalNPCs;
using Terraria;
using Terraria.ModLoader;

namespace Johns_Useful_Weapons.Content.Buffs 
{
    public class FriendlyDebuff : ModBuff
    {
        public float shrinkMultiplier = 0.7f;
        public override void SetStaticDefaults() {
            Main.pvpBuff[Type] = false;
        }   

        public override void Update(NPC npc, ref int buffIndex) {
            npc.GetGlobalNPC<DamageModificationGlobalNPCs>().friendlyDebuff = true;
            npc.friendly = true;
        }  
    }
}