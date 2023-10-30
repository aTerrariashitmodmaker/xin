
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace 新.Projectiles
{
	public class 星黄 : ModProjectile
	{
		public override void SetDefaults()
		{
			Projectile.friendly = true;
			Projectile.width = 64;
			Projectile.height = 64;
			Projectile.penetrate = 20;//可命中敌人数，-1为无限穿透
			Projectile.timeLeft = 20;//弹幕存活时间，帧
			Projectile.tileCollide = false;//是否穿墙，ture为不穿墙
			Projectile.usesLocalNPCImmunity = true;//是否独立无敌帧
			Projectile.localNPCHitCooldown = 10;//独立无敌帧，每x帧造成一次伤害
			Projectile.extraUpdates=0;//额外刷新，1是每帧刷新2次代码
			Projectile.DamageType=DamageClass.Generic;
			Projectile.scale=1f;
		}
		public override void AI()
		{
			var d=Dust.NewDustDirect(Projectile.Center,0,0,DustID.YellowStarDust, 0,0,0,default,2);//生成一个粒子
			d.noGravity=true;
			//int index=Projectile.FindTargetWithLineOfSight(1000);//找1000范围内的敌人
			//if (index>=0)
			//{
				//NPC npc=Main.npc[index];
				//Projectile.velocity=(npc.Center-Projectile.Center).SafeNormalize(Vector2.Zero)*25f;//追击速度
			//}
		}

		public override void SetStaticDefaults()
        {

        }


        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
		{
			
			if (Main.rand.NextBool(50))
			{
				int strike= 200;
				target.SimpleStrikeNPC(strike+target.defense,default,true,0,DamageClass.Generic,default,default,default);//参数为 伤害 击退 击退方向 暴击 是否不造成伤害效果 是否来自联机网络
			}
            
           
        }
	}
}
