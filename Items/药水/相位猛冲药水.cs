using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using 新.Buffs;
using 新.Buffs.相位猛冲系列;
using 新.Items.材料;
using static Terraria.ModLoader.ModContent;

namespace 新.Items.药水
{
	public class 相位猛冲药水: ModItem
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
            player.AddBuff(BuffType<相位猛冲霸符>(), 60 * 60 * 9999);
            return base.UseItem(player);
        }
        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();			
            recipe.AddIngredient(ItemType<巫术基石>(), 1);
			recipe.AddIngredient(ItemID.GoldCoin, 4);
            recipe.AddTile(TileID.MythrilAnvil);
			recipe.Register();
		}
	}
}