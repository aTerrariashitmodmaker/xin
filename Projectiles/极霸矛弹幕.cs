using Microsoft.Xna.Framework;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

using 新.Items;
using 新.Projectiles;
using Terraria.DataStructures;

namespace 新.Projectiles
{
	public class 极霸矛弹幕 : ModProjectile
	{
		public override void SetDefaults()
		{
			Projectile.friendly = true;
			Projectile.width = 1920;
			Projectile.height = 1080;
			Projectile.penetrate = -1;//可命中敌人数，-1为无限穿透
			Projectile.timeLeft = 60;//弹幕存活时间，帧
			Projectile.tileCollide = false;//是否穿墙，ture为不穿墙
			Projectile.usesLocalNPCImmunity = true;//是否独立无敌帧
			Projectile.localNPCHitCooldown = 5;//独立无敌帧，每x帧造成一次伤害
			Projectile.extraUpdates=0;//额外刷新，1是每帧刷新2次代码
			Projectile.ArmorPenetration=800;//盔甲穿透
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("极霸矛弹幕");
		}

        public override void OnSpawn(IEntitySource source)
        {
            Player player = Main.player[Projectile.owner];
			player.Heal(2);
            
        }
        

		public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
		{
			target.SimpleStrikeNPC(damageDone+target.defense,default,default,default,DamageClass.Generic,default,default,default);
			
		}
	}
}
