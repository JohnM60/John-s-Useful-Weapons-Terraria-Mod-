using Johns_Useful_Weapons.Content.Buffs;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

//used to modify the buffs applied to npcs
namespace Johns_Useful_Weapons.Common.GlobalNPCs
{
	internal class DamageModificationGlobalNPCs : GlobalNPC
	{
		public override bool InstancePerEntity => true;
		public bool shrinkDebuff;
		public bool growthDebuff;
		public bool friendlyDebuff;
		public bool hostileDebuff;

		public override void ResetEffects(NPC npc) {
			shrinkDebuff = false;
			growthDebuff = false;
			friendlyDebuff = false;
			hostileDebuff = false;
		}

		public override void DrawEffects(NPC npc, ref Color drawColor) {
			// This simple color effect indicates that the buff is active
			if (shrinkDebuff) {
				drawColor.G = 0;
				drawColor.R = 0;
			}

			if (growthDebuff) {
				drawColor.B = 0;
				drawColor.R = 0;
			}

			if (friendlyDebuff) {
				drawColor.G = 0;
			}

			if (hostileDebuff) {
				drawColor.R = 0;
			}
		}
	}
}