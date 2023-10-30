using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;


namespace 新.Projectiles
{
	public class 手持坠星弹幕 : ModProjectile
	{
		public override void SetDefaults()
		{
			Projectile.friendly = true;
			Projectile.width = 25;
			Projectile.height = 25;
			Projectile.penetrate = 5;//可命中敌人数，-1为无限穿透
			Projectile.timeLeft = 300;//弹幕存活时间，帧
			Projectile.tileCollide = false;//是否穿墙，ture为不穿墙
			Projectile.usesLocalNPCImmunity = true;//是否独立无敌帧
			Projectile.localNPCHitCooldown = 15;//独立无敌帧，每x帧造成一次伤害
			Projectile.extraUpdates=0;//额外刷新，1是每帧刷新2次代码
			Projectile.DamageType=DamageClass.Generic;
			Projectile.scale=1f;
		}
		public override void AI()
		{
			var d=Dust.NewDustDirect(Projectile.Center,0,0,64,0,0,0,default,2);//生成一个粒子
			d.noGravity=true;	
			
		}



		public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
		{
           
            for (int h = 0; h < 3; h++)
            {
                Vector2 vel = new Vector2(0, -1);
                float rand = Main.rand.NextFloat() * 6.283f;
                vel = vel.RotatedBy(rand);
                vel *= 15f;
                Projectile.NewProjectile(target.GetSource_OnHit(target), target.Center, vel, ProjectileType<火>(), 6, 0, Main.myPlayer);
            }
        }
            

       
	}
}
