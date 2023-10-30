using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using 新.Buffs.水魔;
using 新.Items.武器;

namespace 新.Items.药水
{
	public class 水魔爆二级技能书: ModItem
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
            Item.value = 1000000;//价值
            Item.rare = ItemRarityID.Pink;//稀有度
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.scale = 1f*0.5f;
        }
        public override bool? UseItem(Player player)
        {
            player.AddBuff(ModContent.BuffType<水魔二>(), 60 * 60 * 9999);
           
            return base.UseItem(player);
        }
        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Book, 20);
            recipe.AddIngredient(ItemID.Ectoplasm, 20);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 10 );
                     
			recipe.AddIngredient(ItemID.GoldCoin, 400);
            recipe.AddTile(TileID.Bookcases);
			recipe.Register();
		}
	}
}