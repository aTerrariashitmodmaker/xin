using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using 新.Projectiles;

namespace 新.Items.武器

{
	public class 点火杖: ModItem
	{
		

		public override void SetDefaults()
		{
			Item.damage = 3;
			Item.DamageType = DamageClass.Generic;
			Item.width = 400;
			Item.height = 400;
			Item.useTime = 15;
			Item.useAnimation = 30;
			Item.reuseDelay=15;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 6;
			Item.value = 10000;
			Item.rare = ItemRarityID.Blue;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
            Item.crit = 4;
			Item.useTurn=true;
			Item.noMelee=true;
			Item.shoot=ModContent.ProjectileType<火花>();
			Item.shootSpeed=8;
		}
		

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Torch, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}