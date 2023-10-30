
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using 新.Buffs;

namespace 新.Projectiles
{
	public class 火花 : ModProjectile
	{
		
		public override void SetDefaults()
		{
			Projectile.friendly = true;
			Projectile.width = 6;
			Projectile.height = 6;
			Projectile.penetrate = 2;//可命中敌人数，-1为无限穿透
			Projectile.timeLeft = 300;//弹幕存活时间，帧
			Projectile.tileCollide = false;//是否穿墙，ture为不穿墙
			Projectile.usesLocalNPCImmunity = true;//是否独立无敌帧
			Projectile.localNPCHitCooldown = 10;//独立无敌帧，每x帧造成一次伤害
			Projectile.extraUpdates=0;//额外刷新，1是每帧刷新2次代码
			Projectile.DamageType=DamageClass.Generic;
			Projectile.scale=1f;
		}
		public override void AI()
		{
			var d=Dust.NewDustDirect(Projectile.Center,0,0,DustID.Torch,0,0,0,default,2);//生成一个粒子
			d.noGravity=true;

        }

        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            target.AddBuff(BuffType<dl>(), 60 * 2);
            target.AddBuff(BuffID.OnFire, 60 * 5);
            if (Main.rand.NextBool(1))
            {
                int strike = 6;
                target.SimpleStrikeNPC(strike + target.defense, default, false, 0, DamageClass.Generic, default, default, default);//参数为 伤害 击退 击退方向 暴击 是否不造成伤害效果 是否来自联机网络
            }
        }
      
	}
}
