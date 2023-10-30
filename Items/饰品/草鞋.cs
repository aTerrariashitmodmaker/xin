using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.UI;


namespace 新.Items.饰品
{
	public class 草鞋 : ModItem
	{
		
		public override void SetDefaults()
		{
			Item.accessory = true;//判定为饰品，可装备
			Item.width = 22;
			Item.height = 22;
			Item.value = 10000;			
			Item.rare = ItemRarityID.Blue;
		}
		public override void UpdateAccessory(Player player,bool hideVisual)
		{
            player.jumpSpeedBoost += 3f;
            player.jumpBoost = true;
            player.moveSpeed += 0.5f;
            player.runAcceleration += 0.2f;
            player.runSlowdown += 0.3f;
            //player.AddBuff(BuffID.WellFed3, 60);//大饱腹
            player.AddBuff(BuffID.Featherfall, 60);
            player.AddBuff(BuffID.Shine, 60);//光芒
            player.AddBuff(BuffID.NightOwl, 60);//夜猫子
            base.UpdateAccessory(player,hideVisual);			
		}	
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Wood, 100);
			recipe.AddIngredient(ItemID.DirtBlock, 100);			
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}