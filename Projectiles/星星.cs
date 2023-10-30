using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using 新.Buffs;

namespace 新.Projectiles
{
	public class 星星 : ModProjectile
	{
		public override void SetDefaults()
		{
			Projectile.friendly = true;
			Projectile.width = 64;
			Projectile.height = 64;
			Projectile.penetrate = 10;//可命中敌人数，-1为无限穿透
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
			int index=Projectile.FindTargetWithLineOfSight(1000);//找1000范围内的敌人
			if (index>=0)
			{
				NPC npc=Main.npc[index];
				Projectile.velocity=(npc.Center-Projectile.Center).SafeNormalize(Vector2.Zero)*25f;//追击速度
			}
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("");
		}
		

		public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
		{
			target.AddBuff(BuffType<dd>(), 60 * 60);
            for (int h = 0; h < 2; h++)
            {
                Vector2 vel = new Vector2(0, -1);
                float rand = Main.rand.NextFloat() * 6.283f;
                vel = vel.RotatedBy(rand);
                vel *= 15f;
                Projectile.NewProjectile(target.GetSource_OnHit(target),target.Center, vel , ProjectileType<星黄>(), 114, 0, Main.myPlayer);
            }
        }
		

    }
}
