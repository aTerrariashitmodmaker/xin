using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace 新.Items.弹药
{
	public class 南瓜箭: ModItem
	{
		public override string Texture => "Terraria/Images/Projectile_997" ;
        

		public override void SetDefaults() 
		{
			Item.damage = 7; // 弹药伤害是和武器叠加作用的，不要设置的太高
			Item.DamageType = DamageClass.Ranged;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack =9999;//最大堆叠数量
			Item.consumable = true; // 标记为可消耗
			Item.knockBack = 1.5f;//击退力
			Item.value = 10;//价值
			Item.rare = ItemRarityID.Green;//稀有度
			Item.shoot = ProjectileID.FlamingJack;// 代表使用这个弹药会发射什么弹幕
			Item.shootSpeed = 10f; // 子弹速度直接取决于弹药
			Item.ammo = AmmoID.Arrow; 
		}

		
		public override void AddRecipes()
		{
			Recipe recipe2 = CreateRecipe(3996);
			recipe2.AddIngredient(ItemID.CopperCoin, 1);
			recipe2.AddTile(TileID.WorkBenches);
            
            recipe2.Register();
		}
	} 
}