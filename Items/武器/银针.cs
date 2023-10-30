using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using 新.Projectiles;

namespace 新.Items.武器

{
	public class 银针: ModItem
	{
		

		public override void SetDefaults()
		{
			Item.damage = 10;
			Item.DamageType = DamageClass.Generic;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 15;
			Item.useAnimation = 15;
			Item.reuseDelay=15;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.knockBack = 10;
			Item.value = 10000;
			Item.rare = ItemRarityID.Blue;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
            Item.crit = 4;
			Item.useTurn=true;
			Item.noMelee=true;
			Item.shoot=ModContent.ProjectileType<针弹幕>();
			Item.shootSpeed=8;
		}
		

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.SilverBar, 2);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();

            Recipe recipe2 = CreateRecipe();
            recipe2.AddIngredient(ItemID.TungstenBar, 2);
            recipe2.AddTile(TileID.Anvils);
            recipe2.Register();
        }
	}
}