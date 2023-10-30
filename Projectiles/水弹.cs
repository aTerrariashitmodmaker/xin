
using Microsoft.CodeAnalysis;
using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace 新.Projectiles
{
	public class 水弹 : ModProjectile
	{
        Player player = Main.LocalPlayer;
        public override void SetDefaults()
		{
			Projectile.friendly = true;
			Projectile.width = 16;
			Projectile.height = 16;
			Projectile.penetrate = 5;//可命中敌人数，-1为无限穿透
			Projectile.timeLeft = 175;//弹幕存活时间，帧
			Projectile.tileCollide = true;//是否穿墙，ture为不穿墙
			Projectile.usesLocalNPCImmunity = true;//是否独立无敌帧
			Projectile.localNPCHitCooldown = 20;//独立无敌帧，每x帧造成一次伤害
			Projectile.extraUpdates=75;//额外刷新，1是每帧刷新2次代码
			Projectile.DamageType=DamageClass.Magic;
			Projectile.scale=1f;
            
            
		}
		public override void AI()
		{
			var d=Dust.NewDustDirect(Projectile.Center,0,0,DustID.BlueFairy, 0,0,0,default,2);//生成一个粒子
			d.noGravity=true;
            d.velocity *= 0;
            d.position = Projectile.Center;
           
        }
        private void RdEhc(Player player) 
        {
            int dmg = player.GetWeaponDamage(player.HeldItem);
            bool p = player.GetModPlayer<装备效果>().水魔二开;
            int bs = 1;
            if (p)
            {
                bs = 5;
            }          
            if (player.GetModPlayer<符文>().dxcount < 2)//计数器只能使用Global系列的，不能在projectile类用
            {
                player.GetModPlayer<符文>().dxcount++;

            }
            else
            {
                Projectile.NewProjectile(player.GetSource_FromAI(), Projectile.Center, Vector2.Zero, ModContent.ProjectileType<水>(), dmg * 3*bs, 6, player.whoAmI);
                player.GetModPlayer<符文>().dxcount = 0;
            }
        }
        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            RdEhc(player);
        }
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
           // Random random = new Random();
           // float dgre=(float)(random.NextDouble()*6.28f);
            Projectile.velocity = -Projectile.velocity;
           // Projectile.velocity.RotatedBy(dgre);
            return false;
        }
    }
    public class 水弹二 : ModProjectile
    {
        Player player = Main.LocalPlayer;
        public override void SetDefaults()
        {
            Projectile.friendly = true;
            Projectile.width = 16;
            Projectile.height = 16;
            Projectile.penetrate = 5;//可命中敌人数，-1为无限穿透
            Projectile.timeLeft = 175;//弹幕存活时间，帧
            Projectile.tileCollide = true;//是否穿墙，ture为不穿墙
            Projectile.usesLocalNPCImmunity = true;//是否独立无敌帧
            Projectile.localNPCHitCooldown = 20;//独立无敌帧，每x帧造成一次伤害
            Projectile.extraUpdates = 75;//额外刷新，1是每帧刷新2次代码
            Projectile.DamageType = DamageClass.Magic;
            Projectile.scale = 1f;


        }
        public override void AI()
        {
            var d = Dust.NewDustDirect(Projectile.Center, 0, 0, DustID.BlueFairy, 0, 0, 0, default, 2);//生成一个粒子
            d.noGravity = true;
            d.velocity *= 0;
            d.position = Projectile.Center;

        }
        private void RdEhc(Player player)
        {
            int dmg = player.GetWeaponDamage(player.HeldItem);
            bool p = player.GetModPlayer<装备效果>().水魔二开;
            int bs = 1;
            if (p)
            {
                bs = 5;
            }
            if (player.GetModPlayer<符文>().dxcount < 2)//计数器只能使用Global系列的，不能在projectile类用
            {
                player.GetModPlayer<符文>().dxcount++;

            }
            else
            {
                Projectile.NewProjectile(player.GetSource_FromAI(), Projectile.Center, Vector2.Zero, ModContent.ProjectileType<水二>(), dmg * 3 * bs, 6, player.whoAmI);
                player.GetModPlayer<符文>().dxcount = 0;
            }
        }
        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            RdEhc(player);
        }
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            // Random random = new Random();
            // float dgre=(float)(random.NextDouble()*6.28f);
            Projectile.velocity = -Projectile.velocity;
            // Projectile.velocity.RotatedBy(dgre);
            return false;
        }
    }
    public class 水弹三 : ModProjectile
    {
        Player player = Main.LocalPlayer;
        public override void SetDefaults()
        {
            Projectile.friendly = true;
            Projectile.width = 16;
            Projectile.height = 16;
            Projectile.penetrate = 5;//可命中敌人数，-1为无限穿透
            Projectile.timeLeft = 175;//弹幕存活时间，帧
            Projectile.tileCollide = true;//是否穿墙，ture为不穿墙
            Projectile.usesLocalNPCImmunity = true;//是否独立无敌帧
            Projectile.localNPCHitCooldown = 20;//独立无敌帧，每x帧造成一次伤害
            Projectile.extraUpdates = 75;//额外刷新，1是每帧刷新2次代码
            Projectile.DamageType = DamageClass.Magic;
            Projectile.scale = 1f;


        }
        public override void AI()
        {
            var d = Dust.NewDustDirect(Projectile.Center, 0, 0, DustID.BlueFairy, 0, 0, 0, default, 2);//生成一个粒子
            d.noGravity = true;
            d.velocity *= 0;
            d.position = Projectile.Center;

        }
        private void RdEhc(Player player)
        {
            int dmg = player.GetWeaponDamage(player.HeldItem);
            bool p = player.GetModPlayer<装备效果>().水魔二开;
            int bs = 1;
            if (p)
            {
                bs = 5;
            }
            if (player.GetModPlayer<符文>().dxcount < 2)//计数器只能使用Global系列的，不能在projectile类用
            {
                player.GetModPlayer<符文>().dxcount++;

            }
            else
            {
                Projectile.NewProjectile(player.GetSource_FromAI(), Projectile.Center, Vector2.Zero, ModContent.ProjectileType<水三>(), dmg * 3 * bs, 6, player.whoAmI);
                player.GetModPlayer<符文>().dxcount = 0;
            }
        }
        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            RdEhc(player);
        }
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            // Random random = new Random();
            // float dgre=(float)(random.NextDouble()*6.28f);
            Projectile.velocity = -Projectile.velocity;
            // Projectile.velocity.RotatedBy(dgre);
            return false;
        }
    }
}
