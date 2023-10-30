
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using static Terraria.ModLoader.ModContent;
using System;


namespace 新.Projectiles
{
	public class 水 : ModProjectile
	{
		
		public override void SetDefaults()
		{
			Projectile.friendly = true;
		
			Projectile.width =(int)(752*10/1.5f);//老子总结出碰撞箱规则：16为1格，碰撞箱为0时，鼠标在贴图左上角，横向加16，鼠标向贴图右移一格，
            //纵向加16，鼠标向下移动一格，若碰撞箱纵横等于其贴图分辨率，则鼠标在贴图中心，若scale增加n倍，碰撞箱要改为原来的1/n
			//这样鼠标才会在贴图中心，嗨嗨嗨老子真nb
            Projectile.height = (int)(1073 * 10 / 1.5f);
			Projectile.penetrate = -1;//可命中敌人数，-1为无限穿透
			Projectile.timeLeft = 60;//弹幕存活时间，帧
			Projectile.tileCollide = false;//是否穿墙，ture为不穿墙
			Projectile.usesLocalNPCImmunity = true;//是否独立无敌帧
			Projectile.localNPCHitCooldown = 60;//独立无敌帧，每x帧造成一次伤害
			Projectile.extraUpdates=0;//额外刷新，1是每帧刷新2次代码
			Projectile.DamageType=DamageClass.Magic;
			Projectile.scale=0.15f;
            Projectile.alpha = 0;
            Projectile.ignoreWater = true;
			Projectile.light = 1f;
        }
        public override void OnSpawn(IEntitySource source)
        {
	                                 
           
        }
       
    }
}
