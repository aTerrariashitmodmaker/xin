using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Terraria.ModLoader.IO;
using 新.Buffs;
using Microsoft.Xna.Framework;
using System;
using 新.Projectiles;

namespace 新
{
	public class 全局弹幕 : GlobalProjectile //这是一个全局物品的示例
	{
        private void jufen(Projectile projectile, IEntitySource source)
        {
            Player player = Main.player[projectile.owner];
            if (player.HasBuff<飓风霸符>())
            {
                Vector2 vel = new Vector2(player.Center.X + 10f, player.Center.Y);
                if (source is EntitySource_ItemUse)
                {
                    var newSource = projectile.GetSource_FromThis();

                    for (int i = -1; i <= 1; i += 2)
                    {
                        vel = new Vector2(vel.X, vel.Y + i * 10f);
                        Vector2 vel2 = projectile.velocity;
                        vel2 /= vel2.Length();
                        Projectile.NewProjectile(newSource, vel, vel2 * 14f, projectile.type, projectile.damage / 4, (int)projectile.knockBack, player.whoAmI);
                    }
                }
            }
        }
        public override void OnSpawn(Projectile projectile, IEntitySource source)
        { 
            jufen(projectile, source);
        }
        public override bool? CanHitNPC(Projectile projectile, NPC target)
        {
            if (projectile.type==ModContent.ProjectileType<manna>()&&target.type==NPCID.Angler)
            {
                
                projectile.damage = 114514;              
                return true;
            }
            return null;
        }
    }
}	