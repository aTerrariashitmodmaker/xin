using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace 新.Items.材料
{
	public class 巫术基石: ModItem
	{
		public override void SetStaticDefaults()
		{
			
		}

		public override void SetDefaults()
		{
			
			Item.width = 55;
			Item.height = 55;				
			Item.value = 1000000;
			Item.rare = 5;				
		}

		public override void AddRecipes()
		{
			Recipe recipe1 = CreateRecipe();
			recipe1.AddIngredient(ItemID.GoldBar, 15);
            recipe1.AddIngredient(ItemID.JungleSpores, 10);
          
            recipe1.AddIngredient(ItemID.Gel, 50);
            recipe1.AddIngredient(ItemID.Silk, 10);
            recipe1.AddTile(TileID.Anvils);
			recipe1.Register();

			Recipe recipe2 = CreateRecipe();
            recipe2.AddIngredient(ItemID.PlatinumBar, 15);
            recipe2.AddIngredient(ItemID.JungleSpores, 10);
          
            recipe2.AddIngredient(ItemID.Gel, 50);
            recipe2.AddIngredient(ItemID.Silk, 10);
            recipe2.AddTile(TileID.Anvils);
            recipe2.Register();
        }
	}
}