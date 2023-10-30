
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

using static Terraria.ModLoader.ModContent;

namespace 新.Projectiles
{
	public class manna : ModProjectile
	{
		public override void SetDefaults()
		{
			Projectile.friendly = true;
			Projectile.width = 50;
			Projectile.height = 50;
			Projectile.penetrate = -1;//可命中敌人数，-1为无限穿透
			Projectile.timeLeft = 60;//弹幕存活时间，帧
			Projectile.tileCollide = false;//是否穿墙，ture为不穿墙
			Projectile.usesLocalNPCImmunity = true;//是否独立无敌帧
			Projectile.localNPCHitCooldown = 60;//独立无敌帧，每x帧造成一次伤害
			Projectile.extraUpdates=0;//额外刷新，1是每帧刷新2次代码
			Projectile.DamageType=DamageClass.Generic;
			Projectile.scale=2f;
			Projectile.alpha = 64;
		}
	
		
		
		
	}
}
