using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;

using Terraria.Localization;
using 新.Projectiles;
using Terraria.DataStructures;

namespace 新.Items.武器
{
	public class 极霸矛: ModItem
	{
		public static int counter = 0;
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("emmm"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			// Tooltip.SetDefault("我扎我扎，什么？不不不，这可不是牙签，这是极霸矛，王爷的武器，持握时每秒造成全屏伤害.");
		}

		public override void SetDefaults()
		{
			Item.damage = 14;
			Item.DamageType = DamageClass.Generic;
			Item.width = 100;
			Item.height = 100;
			Item.useTime = 15;
			Item.useAnimation = 30;
			Item.useStyle = ItemUseStyleID.Thrust;
			Item.knockBack = 6;
			Item.value = 100*100*100*100;
			Item.rare = ItemRarityID.LightPurple;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.crit=4;
			Item.scale=1f;
			Item.useTurn=true;			
		}

		public override void HoldItem(Player player)
		{
			counter++;
			if (counter == 60)
			{
				counter = 0;
				Projectile.NewProjectile(Item.GetSource_FromAI(),player.Center.X, player.Center.Y, 0f, 0f, ModContent.ProjectileType<极霸矛弹幕>(), Item.damage, 0, player.whoAmI);
			}
		}

		public override bool CanUseItem(Player player)
		{
			if (NPC.downedSlimeKing)
			{
				Item.damage = 8;
			}
			if (NPC.downedBoss1)
			{
				Item.damage = 10;
			}
			if (NPC.downedBoss2)
			{
				Item.damage = 14;
			}
			if (NPC.downedQueenBee)
			{
				Item.damage = 15;
				Item.scale=1.5f;
			}
			if (NPC.downedBoss3)
			{
				Item.damage = 20;
			}
			if (Main.hardMode)
			{
				Item.damage = 28;
				Item.scale=2.25F;
				
			}
			if (NPC.downedMechBossAny)
			{
				Item.damage = 34;
			}
			if (NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3)
			{
				Item.damage = 49;
			}
			if (NPC.downedPlantBoss)
			{
				Item.damage = 62;
			}
			if (NPC.downedGolemBoss)
			{
				Item.damage = 76;
			}
			if (NPC.downedFishron)
			{
				Item.damage = 83;
			}
			if (NPC.downedAncientCultist)
			{
				Item.damage = 94;
			}
			if (NPC.downedMoonlord)
			{
				Item.damage = 114;
			}
			return true;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.FallenStar, 20);
			recipe.AddIngredient(ItemID.Cactus, 100);
			recipe.AddIngredient(ItemID.LifeCrystal, 1);
			recipe.AddIngredient(ItemID.Campfire, 1);
			recipe.AddIngredient(ItemID.RopeCoil, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
		
	}
}