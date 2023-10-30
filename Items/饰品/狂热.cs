using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.UI;
using 新.Items.药水;
using static Terraria.ModLoader.ModContent;


namespace 新.Items.饰品
{
	public class 狂热 : ModItem
	{
		
		public override void SetDefaults()
		{
			Item.accessory = true;//判定为饰品，可装备
			Item.width = 22;
			Item.height = 22;
			Item.value = 10000;			
			Item.rare = 2;
		}
		public override void UpdateAccessory(Player player,bool hideVisual)
		{
			player.GetAttackSpeed(DamageClass.Generic) += 0.05f;
			player.GetDamage(DamageClass.Generic) += 0.05f;
			player.moveSpeed += 0.1f;
		}	
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemType<灵巧披风>(), 1);
			recipe.AddIngredient(ItemID.CopperShortsword, 1);			
			recipe.AddTile(TileID.Anvils);
			recipe.Register();

			Recipe recipe1 = CreateRecipe();
            recipe1.AddIngredient(ItemType<灵巧披风>(), 1);
            recipe1.AddIngredient(ItemID.TinShortsword, 1);
            recipe1.AddTile(TileID.Anvils);
            recipe1.Register();

        }
	}
}