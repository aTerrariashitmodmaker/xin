using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics.PackedVector;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using 新.Buffs;
using 新.Projectiles;

namespace 新.Items.武器

{
	public class 禅杖: ModItem
	{

		Player player = Main.LocalPlayer;
        public override void SetDefaults()
		{
			Item.damage = 5;
			Item.DamageType = DamageClass.Magic;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 60;
			Item.useAnimation = 60;
			Item.reuseDelay=15;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.knockBack = 6;
			Item.value = 10000;
			Item.rare = ItemRarityID.Gray;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
            Item.crit = 4;
			Item.useTurn=true;
			Item.noMelee=true;
			Item.shoot = ModContent.ProjectileType<水>();
			Item.shootSpeed = 10;
			Item.mana =10;
			
		}

        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
			bool p = player.GetModPlayer<装备效果>().水魔二开;
			int bs = 1;
			
            if (p)
            {
				bs = 5;  
            }
			int dmg = (int)(damage * 3 * bs*(1+0.01f*player.statMana/2));
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
				Item.mana = 20;
                if (player.GetModPlayer<符文>().mannacd==0)
                {
					player.GetModPlayer<符文>().mannacd = 10 * 60;
					player.AddBuff(ModContent.BuffType<mannaCd>(), 10 * 60);
                    Projectile.NewProjectile(player.GetSource_FromAI(), player.Center, Vector2.Zero, ModContent.ProjectileType<manna>(), 10, 0, player.whoAmI);
                    player.Heal(10);
					
                }
                flag = false;
            }
            return flag;
        }
        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}