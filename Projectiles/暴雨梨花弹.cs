
using Microsoft.CodeAnalysis;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace 新.Projectiles
{
	public class 暴雨梨花弹 : ModProjectile
	{
        
        public override void SetDefaults()
		{
			Projectile.friendly = true;
			Projectile.width = 32;
			Projectile.height = 32;
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
			var d=Dust.NewDustDirect(Projectile.Center,0,0,DustID.RainbowTorch, 0,0,0,default,2);//生成一个粒子
			d.noGravity=true;
            d.velocity *= 0;
            d.position = Projectile.Center;
            int index = Projectile.FindTargetWithLineOfSight(1000);//找1000范围内的敌人
            if (index >= 0)
            {
                NPC npc = Main.npc[index];
                Projectile.velocity = (npc.Center - Projectile.Center).SafeNormalize(Vector2.Zero) * 25f;//追击速度
            }
            //int index=Projectile.FindTargetWithLineOfSight(1000);//找1000范围内的敌人
            //if (index>=0)
            //{
            //NPC npc=Main.npc[index];
            //Projectile.velocity=(npc.Center-Projectile.Center).SafeNormalize(Vector2.Zero)*25f;//追击速度
            //}
        }
       

    }
}
