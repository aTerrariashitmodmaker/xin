using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.UI;


namespace 新.Items.饰品
{
	public class 守望者铠甲 : ModItem
	{
		
		public override void SetDefaults()
		{
			Item.accessory = true;//判定为饰品，可装备
			Item.width = 22;
			Item.height = 22;
			Item.value = 50000;			
			Item.rare = ItemRarityID.LightRed;
			Item.defense = 16;	
		}
		public override void UpdateAccessory(Player player,bool hideVisual)
		{
			player.endurance += 0.2f;
			player.GetModPlayer<装备效果>().守望者铠甲 = true;
		}	
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.EndurancePotion, 3);
			recipe.AddIngredient(ModContent.ItemType<布甲>(), 2);
            recipe.AddIngredient(ItemID.TurtleScaleMail, 1);
            recipe.AddTile(TileID.MythrilAnvil);
			recipe.Register();
		}
	}
}