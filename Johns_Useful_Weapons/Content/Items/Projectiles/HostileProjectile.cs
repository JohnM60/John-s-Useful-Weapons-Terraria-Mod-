using Johns_Useful_Weapons.Content.Items;
using Johns_Useful_Weapons.Content.Buffs;

using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Johns_Useful_Weapons.Content.Items.Projectiles
{
    public class HostileProjectile : ModProjectile
    {
        public override void SetDefaults() {
            Projectile.width = 10;
            Projectile.height = 10;
            Projectile.friendly = true;
            Projectile.hostile = true;
            Projectile.timeLeft = 100;
            Projectile.tileCollide = true;
            Projectile.knockBack = 0;
        }

        //infict a debuff to an enemy
		public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone) 
		{
			target.AddBuff(ModContent.BuffType<HostileDebuff>(), 1);
			
		}
    }
}