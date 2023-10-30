using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.UI;


namespace 新.Items.饰品
{
	public class 大帽子 : ModItem
	{
		
		public override void SetDefaults()
		{
			Item.accessory = true;//判定为饰品，可装备
			Item.width = 22;
			Item.height = 22;
            Item.value = 100000;
            Item.rare = ItemRarityID.Purple;
		}
		public override void UpdateAccessory(Player player,bool hideVisual)
		{
			player.GetDamage(DamageClass.Summon)*= 1.6f;
			player.GetDamage(DamageClass.Magic) *= 1.6f;
			player.GetModPlayer<装备效果>().大帽子 = true;
        }	
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<无用大棒>(), 2);
			recipe.AddIngredient(ItemID.Ectoplasm, 20);
            recipe.AddIngredient(ItemID.GoldCoin, 11);
            recipe.AddTile(TileID.MythrilAnvil);
			recipe.Register();
		}
	}
}