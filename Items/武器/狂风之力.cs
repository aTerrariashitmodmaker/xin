using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;
using 新.Projectiles;
using Terraria.DataStructures;
using static Terraria.ModLoader.ModContent;
using 新.Buffs.狂风之力系列;
using 新.Items.饰品;

namespace 新.Items.武器
{
	public class 狂风之力: ModItem
	{
		
		
		public override void SetStaticDefaults()
		{
			
		}

		public override void SetDefaults()
		{
			Item.damage = 20;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 64;
			Item.height = 64;
			Item.useTime = 17;
			Item.useAnimation = 17;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.useTurn = true;
			Item.knockBack = 6;
			Item.value = 1000000;
			Item.rare = ItemRarityID.Yellow;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.crit=20;
            Item.shoot = ProjectileType<暴雨梨花弹>();
			Item.shootSpeed = 17f;
            Item.noMelee = true;
            Item.channel = true;
        }
        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            
            Projectile.NewProjectile(source, position, velocity.RotatedBy(0.085f), type, damage, knockback, player.whoAmI);
            Projectile.NewProjectile(source, position, velocity.RotatedBy(-0.085f), type, damage, knockback, player.whoAmI);           
            return true;
        }
        public override bool AltFunctionUse(Player player)
        {
			return true;
        }
        public override bool CanUseItem(Player player)
        {
			int cd = player.GetModPlayer<装备效果>().kfcd;
            if (player.altFunctionUse==2&&cd==0)
            {
				player.GetModPlayer<装备效果>().kfcd = 10 * 60;
				player.AddBuff(BuffType<狂风加速>(), 60 * 3);
				player.AddBuff(BuffType<狂风冷却>(), 60 * 13);
            }
            return base.CanUseItem(player);
        }


        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemType<狂热>(), 1);			
			recipe.AddIngredient(ItemID.DaedalusStormbow, 1);
            recipe.AddIngredient(ItemID.HallowedBar, 10);
            recipe.AddIngredient(ItemID.SoulofLight, 10);
            recipe.AddIngredient(ItemID.SoulofNight, 10);
            recipe.AddTile(TileID.MythrilAnvil);
			recipe.Register();
		}
		
		
	}
}