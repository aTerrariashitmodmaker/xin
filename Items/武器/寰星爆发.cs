using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;
using 新.Projectiles;
using Terraria.DataStructures;
using static Terraria.ModLoader.ModContent;

namespace 新.Items.武器
{
	public class 寰星爆发: ModItem
	{
		public override void SetStaticDefaults()
		{
			
		}

		public override void SetDefaults()
		{
			Item.damage = 114;
			Item.DamageType = DamageClass.Generic;
			Item.width = 64;
			Item.height = 64;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.useTurn = true;
			Item.knockBack = 6;
			Item.value = 10000000;
			Item.rare = ItemRarityID.Red;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.crit=10;

            Item.shoot = ProjectileType<星星>();
			Item.shootSpeed=17;
			//Item.shoot=953	;
			//Item.shootSpeed=15;
		}
		public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
			//本函数用于在武器执行发射弹幕时的操作，返回false可阻止武器原本的发射。true则保留。					
			Projectile.NewProjectile(source, Main.MouseWorld,velocity.RotatedBy(0.07f),type,damage,knockback,player.whoAmI);
			Projectile.NewProjectile(source, Main.MouseWorld, velocity.RotatedBy(-0.07f), type, damage, knockback, player.whoAmI);
			//这里我额外生成两个散射剑气,注意rotatedby是将向量偏转指定弧度，（6.28也就是2PI为一圈）
			//生成一个弹幕，source是生成源，直接使用参数即可。第二个参数是生成位置，position在玩家处。
			//第三个参数是速度，决定弹幕的初始速度（二维向量），第四个参数是ID，第五个参数是伤害，第六个参数是鸡腿
			//第七个参数是弹幕所有者的索引，通常有player参数时直接填player.whoami，不填这个参数可能会引发错误。
			return false; 
		}	

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.StarWrath, 1);
			recipe.AddIngredient(ItemID.Starfury, 1);
			recipe.AddIngredient(ItemID.LunarBar, 20);
			
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.Register();
		}
		
		
	}
}