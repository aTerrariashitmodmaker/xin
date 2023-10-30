using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;


using 新.Buffs.征服者系列;
using 新.Buffs.致命节奏系列;
using static Terraria.ModLoader.ModContent;
using 新.Buffs.战争律动系列;
using 新.Buffs;
using 新.Buffs.电刑系列;
using 新.Buffs.相位猛冲系列;
using 新.Projectiles;
using Terraria.GameInput;
using 新.Items.饰品;
using 新.Items.武器;

namespace 新
{
	

    public class 符文 : ModPlayer
    {
        public bool 征服者 = false;
        public bool 征服者一 = false;
        public bool 征服者二 = false;
        public bool 征服者三 = false;
        public bool 征服者四 = false;
        public bool 征服者五 = false;
        public bool 征服者六 = false;

        public bool 致命节奏 = false;
        public bool 致命节奏一 = false;
        public bool 致命节奏二 = false;
        public bool 致命节奏三 = false;
        public bool 致命节奏四 = false;
        public bool 致命节奏五 = false;
        public bool 致命节奏六 = false;

        public bool 电刑= false;
        public bool 电刑冷却= false;       
        public int dxcs = 0;

        public bool 相位猛冲=false;
        public bool 相位猛冲冷却=false;
        public int xwcs = 0;

        public int dxcd = 0;
        public int dxcount = 0;
        public int sdcount= 0;
        public int mannacd= 0;
        public override void ResetEffects()
        {

            征服者 = false;
            征服者一 = false;
            征服者二 = false;
            征服者三 = false;
            征服者四 = false;
            征服者五 = false;
            征服者六 = false;

            致命节奏 = false;
            致命节奏一 = false;
            致命节奏二 = false;
            致命节奏三 = false;
            致命节奏四 = false;
            致命节奏五 = false;
            致命节奏六 = false;

            电刑 = false;
            if (dxcd > 0)
            {
                dxcd--;

            }
            if (mannacd > 0)
            {
                mannacd--;
            }

            相位猛冲 = false;
            相位猛冲冷却 = false;
           
            base.ResetEffects();
        }
        private void AddDxDmg(int damage, NPC target, Player player)
        {
            if (dxcd <= 0)
            {
                if (dxcount < 2)
                {
                    player.GetModPlayer<符文>().dxcount++;
                }
                else
                {
                    dxcd = 60 * 8;
                    dxcount = 0;
                    player.AddBuff(BuffType<电刑冷却>(), 8 * 60);
                    int dmg = 500 + damage * 3;
                    if (Main.hardMode)
                        dmg = 1200 + damage * 7;
                    Projectile.NewProjectile(player.GetSource_FromAI(), target.Center, Vector2.Zero, ProjectileID.ThunderStaffShot, dmg, 0, 0);
                }
            }
        }
        public override void OnHitNPCWithProj(Projectile proj, NPC target, NPC.HitInfo hit, int damageDone)
        {
            Player player = Main.player[proj.owner];
            int xx = damageDone / 80 + 1;
            if (征服者)
            {
                player.AddBuff(BuffType<征服一>(), 60 * 6);
            }
            if (征服者 && 征服者一)
            {
                player.AddBuff(BuffType<征服二>(), 60 * 6);
            }
            if (征服者 && 征服者二)
            {
                player.AddBuff(BuffType<征服三>(), 60 * 6);
            }
            if (征服者 && 征服者三)
            {
                player.AddBuff(BuffType<征服四>(), 60 * 6);
            }
            if (征服者 && 征服者四)
            {
                player.AddBuff(BuffType<征服五>(), 60 * 6);
            }
            if (征服者 && 征服者五)
            {
                player.AddBuff(BuffType<征服六>(), 60 * 6);
            }
            if (征服者 && 征服者六)
            {
                Projectile.NewProjectile(proj.GetSource_FromAI(), proj.Center, Vector2.Zero,
                     ProjectileID.VampireHeal, 0, 0, proj.owner, proj.owner, xx);
            }

            if (致命节奏)
            {
                player.AddBuff(BuffType<致命一>(), 60 * 6);
            }
            if (致命节奏 && 致命节奏一)
            {
                player.AddBuff(BuffType<致命二>(), 60 * 6);
            }
            if (致命节奏 && 致命节奏二)
            {
                player.AddBuff(BuffType<致命三>(), 60 * 6);
            }
            if (致命节奏 && 致命节奏三)
            {
                player.AddBuff(BuffType<致命四>(), 60 * 6);
            }
            if (致命节奏 && 致命节奏四)
            {
                player.AddBuff(BuffType<致命五>(), 60 * 6);
            }
            if (致命节奏 && 致命节奏五)
            {
                player.AddBuff(BuffType<致命六>(), 60 * 6);
            }
            if (致命节奏 && 致命节奏六)
            {
                player.GetCritChance(DamageClass.Generic) += 15f;
            }

            if (电刑)
            {
                AddDxDmg(damageDone, target, Main.player[proj.owner]);
            }

            if (相位猛冲)
            {
                if (!相位猛冲冷却)
                {
                    xwcs++;
                    if (xwcs == 3)
                    {
                        player.AddBuff(BuffType<相位猛冲效果>(), 60 * 3);
                        player.AddBuff(BuffType<相位猛冲冷却>(), 60 * 8);
                        xwcs = 0;
                    }
                }
            }
            base.OnHitNPCWithProj(proj, target, hit, damageDone);
        }
        public override void OnHitNPCWithItem(Item item, NPC target, NPC.HitInfo hit, int damageDone)
        {
            Player player = Main.player[item.ownTime];
            int xx = damageDone / 40 + 1;

            if (征服者)
            {
                player.AddBuff(BuffType<征服一>(), 60 * 6);
            }
            if (征服者 && 征服者一)
            {
                player.AddBuff(BuffType<征服二>(), 60 * 6);
            }
            if (征服者 && 征服者二)
            {
                player.AddBuff(BuffType<征服三>(), 60 * 6);
            }
            if (征服者 && 征服者三)
            {
                player.AddBuff(BuffType<征服四>(), 60 * 6);
            }
            if (征服者 && 征服者四)
            {
                player.AddBuff(BuffType<征服五>(), 60 * 6);
            }
            if (征服者 && 征服者五)
            {
                player.AddBuff(BuffType<征服六>(), 60 * 6);
            }
            if (征服者 && 征服者六)
            {
                Projectile.NewProjectile(target.GetSource_FromAI(), target.Center, Vector2.Zero,
                     ProjectileID.VampireHeal, 0, 0, 0, 0, xx);
            }

            if (致命节奏)
            {
                player.AddBuff(BuffType<致命一>(), 60 * 6);
            }
            if (致命节奏 && 致命节奏一)
            {
                player.AddBuff(BuffType<致命二>(), 60 * 6);
            }
            if (致命节奏 && 致命节奏二)
            {
                player.AddBuff(BuffType<致命三>(), 60 * 6);
            }
            if (致命节奏 && 致命节奏三)
            {
                player.AddBuff(BuffType<致命四>(), 60 * 6);
            }
            if (致命节奏 && 致命节奏四)
            {
                player.AddBuff(BuffType<致命五>(), 60 * 6);
            }
            if (致命节奏 && 致命节奏五)
            {
                player.AddBuff(BuffType<致命六>(), 60 * 6);
            }
            if (致命节奏 && 致命节奏六)
            {
                player.GetCritChance(DamageClass.Generic) += 15f;
            }

            if (电刑)
            {
                AddDxDmg(damageDone, target, player);
            }

            if (相位猛冲)
            {
                if (!相位猛冲冷却)
                {
                    xwcs++;
                    if (xwcs == 3)
                    {
                        player.AddBuff(BuffType<相位猛冲效果>(), 60 * 3);
                        player.AddBuff(BuffType<相位猛冲冷却>(), 60 * 8);
                        xwcs = 0;
                    }
                }
            }
            base.OnHitNPCWithItem(item, target, hit, damageDone);
        }
    }
    public class 装备效果 : ModPlayer
    {
        public bool 收集者 = false;
        public bool 十字镐 = false;
        public bool 战争律动=false;
        public int zzldcd = 0;
        public StatModifier ExtraDmg = new(1f, 1f);
        public int kfcd = 0;
        public bool 守望者铠甲 = false;
        public bool 兰顿 = false;
        public int ldcd= 0;
        public bool 无尽之刃= false;
        public bool 大帽子 = false;
        public bool 无用大棒 = false;
        public bool 增幅典籍 = false;
        public int 银针次数= 0;
        public bool 水魔二开 = false;

        public override void ResetEffects()
        {
            
            收集者 = false;
            十字镐 = false;
            战争律动 = false;
            无尽之刃 = false;
            大帽子= false;
            无用大棒 = false;
            增幅典籍=false;


            ExtraDmg = new(1f, 1f);
           
            if (zzldcd>0)
            {
                zzldcd--;
            }
            if (kfcd>0)
            {
                kfcd--;
            }
            if (ldcd>0)
            {
                ldcd--;
            }
            守望者铠甲 = false;
            兰顿 = false;
            水魔二开 = false;
            base.ResetEffects();
        }
        public override void ProcessTriggers(TriggersSet triggersSet)
        {
            Player player = Main.LocalPlayer;
            if (兰顿==true )
            {
                if (新.qbkey.JustPressed && ldcd <= 0)
                {
                    ldcd = 60 * 30;
                    player.AddBuff(BuffType<兰顿冷却>(), 30 * 60);
                    Projectile.NewProjectile(player.GetSource_FromAI(), player.Center, Vector2.Zero, ProjectileType<兰顿弹幕>(), 100, 0, player.whoAmI);
                }
            }
           
        }
        private void AddExtraDmg(float damage, NPC target, ref NPC.HitModifiers modifiers, bool proj,Player player)
        {
            if (zzldcd <= 0)
            {
                // 重置CD
                 
                zzldcd = 60 * 8;
                player.AddBuff(BuffType<战争律动冷却>(), 8* 60);
                // 计算并附加伤害
                float dmg = ExtraDmg.CombineWith(modifiers.FinalDamage).ApplyTo(damage)+target.life*0.08f;
                modifiers.FlatBonusDamage += dmg;
               
            }
        }
       
        private void AddKFDmg(NPC target, Projectile proj, Player player, ref NPC.HitModifiers modifiers,float damage,float bj)
        {
            
            if (proj.type==ProjectileType<暴雨梨花弹>())
            {
                float lf = (target.lifeMax - target.life) * 0.005f;
                StatModifier ExDmg = new(2.5f * bj * 0.01f, 1f);
                float dmg = ExDmg.CombineWith(modifiers.FinalDamage).ApplyTo(damage)+lf;            
                modifiers.FlatBonusDamage += dmg;
                
            }
            
        }
        private void minusDmgSwz( NPC npc)
        {
            Player player = Main.LocalPlayer;
            if (守望者铠甲)
            {
                float xx = npc.damage * 0.1f + 10;
                Projectile.NewProjectile(player.GetSource_FromAI(), player.Center, Vector2.Zero,
                    ProjectileID.VampireHeal, 0, 0, 0, 0, xx);

            }
        }
        private void minusDmgSwz(Projectile proj)
        {
            Player player = Main.LocalPlayer;
            if (守望者铠甲)
            {
                float xx = proj.damage * 0.1f + 10;
                Projectile.NewProjectile(player.GetSource_FromAI(), player.Center, Vector2.Zero,
                    ProjectileID.VampireHeal, 0, 0, 0, 0, xx);

            }
        }
        private void addWjDmg(NPC target, Player player)
        {
            if (无尽之刃)
            {
                int strike = player.GetWeaponDamage(player.HeldItem);
                target.SimpleStrikeNPC((int)(strike * 0.25f), default, true, 0, default);
            }
        }
        private void addMgDmg(NPC target, Player player)
        {
            Item item = player.HeldItem;
            bool flag = false;
            if (大帽子)
            {
                if (item.DamageType==DamageClass.Magic| item.DamageType == DamageClass.Summon)
                {
                    if (target.life<=target.lifeMax*0.5f)
                    {
                        flag = true;
                    }
                    int strike = player.GetWeaponDamage(item);
                    target.SimpleStrikeNPC((int)(strike * 0.3f)+120, default, flag, 0, default);
                }
            }
            if (无用大棒)
            {
                if (item.DamageType == DamageClass.Magic | item.DamageType == DamageClass.Summon)
                {
                    int strike = player.GetWeaponDamage(item);
                    target.SimpleStrikeNPC((int)(strike * 0.15f) +50, default, false, 0, default);
                }
            }
            if (增幅典籍)
            {
                if (item.DamageType == DamageClass.Magic | item.DamageType == DamageClass.Summon)
                {
                    int strike = player.GetWeaponDamage(item);
                    target.SimpleStrikeNPC((int)(strike * 0.05f) + 20, default, false, 0, default);
                }
            }
        }
        private void needleDmg(Projectile proj, Player player)
        {
            int dmg = player.GetWeaponDamage(player.HeldItem);
            if (proj.type == ProjectileType<针弹幕>())
            {
                银针次数++;
                if (银针次数 == 2)
                {
                    Projectile.NewProjectile(player.GetSource_FromAI(), proj.Center, Vector2.Zero, ProjectileID.HellfireArrow, dmg * 3, 10, player.whoAmI);
                }
            }
        }
        public override void OnHitByNPC(NPC npc, Player.HurtInfo hurtInfo)
        {
            minusDmgSwz(npc);    
        }
        public override void OnHitByProjectile(Projectile proj, Player.HurtInfo hurtInfo)
        {
            minusDmgSwz(proj);
        }      
        public override void ModifyHitNPCWithItem(Item item, NPC target, ref NPC.HitModifiers modifiers)
        {
            Player player = Main.player[item.ownTime];         
            if (战争律动)
            {
                 AddExtraDmg(item.damage, target, ref modifiers, false,player);
            }                  
        }
        public override void ModifyHitNPCWithProj(Projectile proj, NPC target, ref NPC.HitModifiers modifiers)
        {
            Player player = Main.player[proj.owner];
            float bj = player.GetWeaponCrit(player.HeldItem);
            if (战争律动)
            {
                 AddExtraDmg(proj.damage, target, ref modifiers, false, player);
            }           
            AddKFDmg(target,proj, player, ref modifiers, proj.damage,bj);
        }
        public override void OnHitNPCWithProj(Projectile proj, NPC target, NPC.HitInfo hit, int damageDone)
        {
            
            Player player = Main.LocalPlayer;                  
            addWjDmg(target, player);
            needleDmg(proj, player);
            
        }
        public override void OnHitNPCWithItem(Item item, NPC target, NPC.HitInfo hit, int damageDone)
        {
            Player player = Main.LocalPlayer;
            if (无尽之刃)
            {
                int strike = player.GetWeaponDamage(player.HeldItem);
                target.SimpleStrikeNPC((int)(strike * 0.4f), default, true, 0, default);
            }
        }
        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            Player player = Main.LocalPlayer;
            if (收集者)
            {
                if (target.life > target.lifeMax / 10)
                {
                    if (Main.rand.NextBool(20))
                    {
                        target.buffImmune[BuffType<收集霸符>()] = false;
                        target.AddBuff(BuffType<收集霸符>(), 60);
                    }
                }
                else
                {
                    target.buffImmune[BuffType<死与税>()] = false;
                    target.AddBuff(BuffType<死与税>(), 1800);
                }
            }
            if (十字镐)
            {
                target.buffImmune[BuffType<十字镐霸符>()] = false;
                target.AddBuff(BuffType<十字镐霸符>(), 60);

            }
           addMgDmg(target, player);
        }
    }
}