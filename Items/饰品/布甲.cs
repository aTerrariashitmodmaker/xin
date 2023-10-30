using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.UI;


namespace 新.Items.饰品
{
	public class 布甲 : ModItem
	{
		
		public override void SetDefaults()
		{
			Item.accessory = true;//判定为饰品，可装备
			Item.width = 22;
			Item.height = 22;
			Item.value = 10000;			
			Item.rare = ItemRarityID.Blue;
			Item.defense = 4;
		}
		public override void UpdateAccessory(Player player,bool hideVisual)
		{
			player.endurance += 0.04f;
		}	
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Silk, 3);
			recipe.AddIngredient(ItemID.StoneBlock, 10);				
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}