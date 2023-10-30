using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.UI;


namespace 新.Items.饰品
{
	public class 增幅典籍 : ModItem
	{
		
		public override void SetDefaults()
		{
			Item.accessory = true;//判定为饰品，可装备
			Item.width = 22;
			Item.height = 22;
            Item.value = 10000;
            Item.rare = ItemRarityID.Green;
		}
		public override void UpdateAccessory(Player player,bool hideVisual)
		{
			player.GetDamage(DamageClass.Summon) += 0.05f;
			player.GetDamage(DamageClass.Magic) += 0.05f;
			player.GetModPlayer<装备效果>().增幅典籍 = true;

        }	
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Book, 2);
			
           
            recipe.AddTile(TileID.Bookcases);
			recipe.Register();
		}
	}
}