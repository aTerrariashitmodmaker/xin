using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using 新.Buffs;
using 新.Buffs.战争律动系列;
using 新.Items.材料;
using static Terraria.ModLoader.ModContent;

namespace 新.Items.药水
{
	public class 战争律动药水: ModItem
	{
		public override void SetStaticDefaults()
		{
			
		}
		public override void SetDefaults()
		{
            Item.useStyle = ItemUseStyleID.DrinkLiquid;
            Item.UseSound = SoundID.Item3;
            Item.useTurn = true;
            Item.maxStack = 1;//最大堆叠数量
            Item.consumable = false; // 标记为可消耗			
            Item.value = 10000;//价值
            Item.rare = ItemRarityID.Purple;//稀有度
            Item.useAnimation = 15;
            Item.useTime = 15;
        }
        public override bool? UseItem(Player player)
        {
            player.AddBuff(BuffType<战争律动霸符>(), 60 * 60 * 9999);
            return base.UseItem(player);
        }
        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();			
            recipe.AddIngredient(ItemID.GoldBar, 10);
			recipe.AddIngredient(ItemID.GoldCoin, 4);
            recipe.AddTile(TileID.Anvils);
			recipe.Register();

            Recipe recipe2 = CreateRecipe();
            recipe2.AddIngredient(ItemID.PlatinumBar, 10);
            recipe2.AddIngredient(ItemID.GoldCoin, 4);
            recipe2.AddTile(TileID.Anvils);
            recipe2.Register();


        }
    }
}