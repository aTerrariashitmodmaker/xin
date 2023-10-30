using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using 新.Projectiles;

namespace 新.Items.武器
{
	public class 手持坠星: ModItem
	{
		

		public override void SetDefaults()
		{
			Item.damage = 6;
			Item.DamageType = DamageClass.Generic;
			Item.width = 400;
			Item.height = 400;
			Item.useTime = 15;
			Item.useAnimation = 15;
			Item.reuseDelay=17;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 6;
			Item.value = 10000;
            Item.rare = ItemRarityID.Orange;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.crit=4;
			Item.useTurn=true;
			Item.noMelee=true;
			Item.shoot=ModContent.ProjectileType<手持坠星弹幕>();
			Item.shootSpeed=12;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.FallenStar, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}