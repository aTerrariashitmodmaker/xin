using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.UI;


namespace 新.Items.饰品
{
	public class 兰顿 : ModItem
	{
		
		public override void SetDefaults()
		{
			Item.accessory = true;//判定为饰品，可装备
			Item.width = 22;
			Item.height = 22;
			Item.value = 100000;			
			Item.rare = ItemRarityID.Lime;
			Item.defense = 24;
		}
		public override void UpdateAccessory(Player player,bool hideVisual)
		{
			player.endurance += 0.24f;
            player.statLifeMax2 += 80;
            player.GetModPlayer<装备效果>().守望者铠甲 = true;
            player.GetModPlayer<装备效果>().兰顿 = true;
        }	
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<巨人腰带>(), 1);
			recipe.AddIngredient(ModContent.ItemType<守望者铠甲>(), 1);
            recipe.AddIngredient(ItemID.LifeCrystal, 1);
            recipe.AddIngredient(ItemID.LifeFruit, 1);
            recipe.AddTile(TileID.MythrilAnvil);
			recipe.Register();
		}
	}
}