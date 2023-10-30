using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace 新.Perfix
{
	public class 神力: ModPrefix
	{
		public override void SetStaticDefaults()
		{
			
			
		}

		public virtual float Power=>1.25f;
		public override PrefixCategory Category=>(PrefixCategory)3;
		
		public override float RollChance(Item item)
		{
			return 5f;
		}
		
		public override bool CanRoll(Item item)
		{
			return true;
		}

		public override void SetStats(ref float damageMult,ref float knockbackMult,ref float useTimeMult,ref float scaleMult,ref float shootSpeedMult,ref float manaMult,ref int critBonus)
		{
            damageMult *= 1f + 0.85f;
            critBonus += 10;
        }

		public override void ModifyValue(ref float valueMult)
		{
			valueMult*=1f+0.01f*Power;
		}

		public override void Apply(Item item)
		{

		}

	}
}