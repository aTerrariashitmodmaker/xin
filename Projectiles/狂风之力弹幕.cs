using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using 新.Projectiles;
using Terraria.DataStructures;
using System;


namespace 新.Projectiles
{
	public class 狂风之力弹幕 : ModProjectile
	{
		public override string Texture => "Terraria/Images/Projectile_0";//因为是伪武器，就直接用透明贴图好了
        //这行可以将弹幕的材质引用指向原版对应路径的贴图，非常好用，这样就不用准备图片了
        //材质路径格式：Terraria/Images/Item_ 等等，具体请参考解包出来的贴图包名称
        Player player => Main.player[Projectile.owner];
        //定义生成弹幕时传入的owner参数对应的玩家 

		public override void SetDefaults()
		{
      	 	Projectile.width = Projectile.height = 32;//长宽为两格物块长度
            //注意细长形弹幕千万不能照葫芦画瓢把长宽按贴图设置因为碰撞箱是固定的，不会随着贴图的旋转而旋转
        	Projectile.friendly = true;//友方弹幕
        	Projectile.tileCollide = false;//false就能让他穿墙
       		Projectile.timeLeft = 10;//消散时间
       		Projectile.aiStyle = -1;//不使用原版AI
       		Projectile.DamageType = DamageClass.Ranged;//远程
       		Projectile.penetrate = 1;//表示能穿透几次
       		Projectile.ignoreWater = true;//无视液体
       		base.SetDefaults();
   		}

		public override bool? CanDamage() 
		{
			return false;
		}

		public override void AI()
		{
			if(player.channel)
			{
				player.direction = (Main.MouseWorld - player.Center).X > 0 ? 1 : -1; //让玩家面朝枪指着的半边
			
				if(player.direction == 1 )
				{
					player.itemRotation = (Main.MouseWorld - player.Center).ToRotation();//获取玩家到弹幕向量的方向 
				}
				else
				{
					player.itemRotation = (Main.MouseWorld - player.Center).ToRotation() + 3.1415926f;//反之需要+半圈 
				}

				Projectile.timeLeft = 2;//因为这是以弹幕作为武器，所以松手后必须马上消失! 
				player.itemTime = player.itemAnimation = 10;//同样的我们需要让玩家保持使用状态 
				Projectile.Center = player.Center;
				Projectile.ai[1]++;
                Vector2 vel = Main.MouseWorld - player.Center;
                if (Projectile.ai[1] > 15)
                {
					Projectile.ai[1] = 0;
                    for (int i = -1; i <= 1; i++)
                    {
                        vel /= vel.Length();
                        vel = vel.RotatedBy(0.1f * i);
                        Projectile.NewProjectile(Projectile.GetSource_FromAI(), Projectile.Center, vel * 17f, ProjectileType<暴雨梨花弹>(), Projectile.damage, 0, player.whoAmI);
                    }
                }
                
			}	
			base.AI();
			
		}		
	}	
}