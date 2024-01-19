using Microsoft.Xna.Framework;
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
        //makes the npc have passive AI and be still
        public override void Update(NPC npc, ref int buffIndex) {
            npc.GetGlobalNPC<DamageModificationGlobalNPCs>().friendlyDebuff = true;
            npc.friendly = true;
            npc.aiStyle = 7;
            Vector2 stayPut = new Vector2(0, 0);
            npc.velocity = Vector2.Multiply(npc.velocity, stayPut);
        }  
    }
}