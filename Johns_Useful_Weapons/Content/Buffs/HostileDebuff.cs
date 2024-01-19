using Microsoft.Xna.Framework;
using Johns_Useful_Weapons.Common.GlobalNPCs;
using Terraria;
using Terraria.ModLoader;

namespace Johns_Useful_Weapons.Content.Buffs 
{
    public class HostileDebuff : ModBuff
    {
        public float shrinkMultiplier = 0.7f;
        public override void SetStaticDefaults() {
            Main.pvpBuff[Type] = false;
        }   
        //This changes the npc to be hostile, be still for a moment and have zombie ai
        public override void Update(NPC npc, ref int buffIndex) {
            npc.GetGlobalNPC<DamageModificationGlobalNPCs>().hostileDebuff = true;
            npc.friendly = false;
            npc.aiStyle = 3;
            Vector2 stayPut = new Vector2(0, 0);
            npc.velocity = Vector2.Multiply(npc.velocity, stayPut);
        }  
    }
}