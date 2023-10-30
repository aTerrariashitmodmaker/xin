
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using 新.Buffs;

namespace 新.Projectiles
{
	public class 针弹幕 : ModProjectile
	{
		
		public override void SetDefaults()
		{
			Projectile.friendly = true;
			Projectile.width = 6;
			Projectile.height = 6;
			Projectile.penetrate = 1;//可命中敌人数，-1为无限穿透
			Projectile.timeLeft = 300;//弹幕存活时间，帧
			Projectile.tileCollide = true;//是否穿墙，ture为不穿墙
			Projectile.usesLocalNPCImmunity = true;//是否独立无敌帧
			Projectile.localNPCHitCooldown = 10;//独立无敌帧，每x帧造成一次伤害
			Projectile.extraUpdates=0;//额外刷新，1是每帧刷新2次代码
			Projectile.DamageType=DamageClass.Generic;
			Projectile.scale=1f;
		}
		

        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            
        }
      
	}
}
