using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.UI;


namespace 新.Items.饰品
{
	public class 巨人腰带 : ModItem
	{
		
		public override void SetDefaults()
		{
			Item.accessory = true;//判定为饰品，可装备
			Item.width = 22;
			Item.height = 22;
			Item.value = 20000;			
			Item.rare = ItemRarityID.Green;
		}
		public override void UpdateAccessory(Player player,bool hideVisual)
		{
			player.statLifeMax2 += 50;
		}	
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.LifeCrystal, 1);
			recipe.AddIngredient(ModContent.ItemType<真生命水晶>(), 1);			
			recipe.AddTile(TileID.Hellforge);
			recipe.Register();
		}
	}
}