using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace 新.Perfix
{
	public class 冠世: ModPrefix
	{
		public override void SetStaticDefaults()
		{
			
			
		}

		public virtual float Power=>1.25f;
		public override PrefixCategory Category=>(PrefixCategory)1;
		
		public override float RollChance(Item item)
		{
			return 4f;
		}
		
		public override bool CanRoll(Item item)
		{
			return true;
		}

		public override void SetStats(ref float damageMult,ref float knockbackMult,ref float useTimeMult,ref float scaleMult,ref float shootSpeedMult,ref float manaMult,ref int critBonus)
		{
            damageMult *= 1f + 0.35f;
            critBonus += 25;
            useTimeMult *= 0.7f;
            shootSpeedMult *= 1f + 0.3f;
        }

		public override void ModifyValue(ref float valueMult)
		{
			valueMult*=1f+0.05f*Power;
		}

		public override void Apply(Item item)
		{

		}

	}
}