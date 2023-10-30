using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using 新.Buffs;
using 新.Buffs.水魔;
using 新.Projectiles;

namespace 新.Items.武器

{
	public class 血海邪皇: ModItem
	{
		

        public override void SetDefaults()
		{
			Item.damage = 50;
			Item.DamageType = DamageClass.Magic;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 30;
			Item.useAnimation = 30;
			Item.reuseDelay=15;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.knockBack = 6;
			Item.value = 10000;
            Item.rare = ItemRarityID.Pink;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
            Item.crit = 4;
			Item.useTurn=true;
			Item.noMelee=true;
			Item.shoot = ModContent.ProjectileType<水三>();
			Item.shootSpeed = 10;
			Item.scale = 0.3f;
            Item.mana = 40;
			
		}
        public override void HoldItem(Player player)
        {
            player.AddBuff(ModContent.BuffType<血海霸符>(), 60);
            player.manaRegen += 4;
            player.manaRegenDelay *= 0.35f;
            
        }

        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            bool p = player.GetModPlayer<装备效果>().水魔二开;
            int bs = 1;
            if (p)
            {
                bs = 5;
            }
            int dmg = (int)(damage * 3 * bs * (1 + 0.01f * player.statMana / 2));
            Projectile.NewProjectile(player.GetSource_FromAI(), Main.MouseWorld, Vector2.Zero, type, dmg, knockback*2, player.whoAmI);
            return false;
            
        }
        public override bool AltFunctionUse(Player player)
        {
            return true;
        }
        public override bool CanUseItem(Player player)
        {
			bool flag=true;
            if (player.altFunctionUse == 2)
            {
                Item.mana = 30;
                if (player.GetModPlayer<符文>().mannacd==0)
                {
					player.GetModPlayer<符文>().mannacd = 10 * 60;
					player.AddBuff(ModContent.BuffType<mannaCd>(), 10 * 60);
                    Projectile.NewProjectile(player.GetSource_FromAI(), player.Center, Vector2.Zero, ModContent.ProjectileType<manna>(), 10, 0, player.whoAmI);
                    player.Heal(30);
                    player.AddBuff(ModContent.BuffType<润物无声>(),60*5);
					
                }
                flag = false;
            }
            return flag;
        }
        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.PixieDust, 20);
            recipe.AddIngredient(ItemID.UnicornHorn, 2);
            recipe.AddIngredient(ItemID.SoulofLight, 15);
            recipe.AddIngredient(ItemID.SoulofNight, 15);
            recipe.AddIngredient(ModContent.ItemType<地煞权杖>(), 1);
            recipe.AddTile(TileID.MythrilAnvil);
			recipe.Register();
		}
	}
    public class 血海改 : ModItem
    {


        public override void SetDefaults()
        {
            Item.damage = 25;
            Item.DamageType = DamageClass.Magic;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 10;
            Item.useAnimation = 20;
            Item.reuseDelay = 15;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.knockBack = 6;
            Item.value = 10000;
            Item.rare = ItemRarityID.Pink;
            Item.UseSound = SoundID.Item72;
            Item.autoReuse = true;
            Item.crit = 4;
            Item.useTurn = true;
            Item.noMelee = true;
            Item.shoot = ModContent.ProjectileType<水弹三>();
            Item.shootSpeed = 20;
            Item.mana = 20;

        }
        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            bool p = player.GetModPlayer<装备效果>().水魔二开;
            int bs = 1;
            if (p)
            {
                bs = 5;
            }
            int dmg = (int)(damage * 2 * bs * (1 + 0.01f * player.statMana / 2));
            Projectile.NewProjectile(player.GetSource_FromAI(), position, velocity, type, dmg, knockback, player.whoAmI);
            return false;
        }
        public override void HoldItem(Player player)
        {
            player.AddBuff(ModContent.BuffType<血海霸符>(), 60);
            player.manaRegen += 4;
            player.manaRegenDelay *= 0.35f;
            
        }
        public override bool AltFunctionUse(Player player)
        {
            return true;
        }
        public override bool CanUseItem(Player player)
        {
            bool flag = true;
            if (player.altFunctionUse == 2)
            {
                Item.mana = 20;
                if (player.GetModPlayer<符文>().mannacd == 0)
                {
                    player.GetModPlayer<符文>().mannacd = 10 * 60;
                    player.AddBuff(ModContent.BuffType<mannaCd>(), 10 * 60);
                    Projectile.NewProjectile(player.GetSource_FromAI(), player.Center, Vector2.Zero, ModContent.ProjectileType<manna>(), 10, 0, player.whoAmI);
                    player.Heal(30);
                    player.AddBuff(ModContent.BuffType<润物无声>(), 60 * 5);

                }
                flag = false;
            }
            return flag;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.PixieDust, 20);
            recipe.AddIngredient(ItemID.UnicornHorn, 2);
            recipe.AddIngredient(ItemID.SoulofLight, 15);
            recipe.AddIngredient(ItemID.SoulofNight, 15);
            recipe.AddIngredient(ModContent.ItemType<地煞权杖>(), 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();

            Recipe recipe2 = CreateRecipe();
            recipe2.AddIngredient(ModContent.ItemType<血海邪皇>(), 1);
            recipe2.Register();
        }
    }
}