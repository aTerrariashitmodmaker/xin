using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace 新.Perfix
{
	public class 回复一: ModPrefix
	{
		public override void SetStaticDefaults()
		{
			
			
		}

		public virtual float Power=>1.25f;
		public override PrefixCategory Category=> PrefixCategory.Accessory;
		
		public override float RollChance(Item item)
		{
			return 5f;
		}
		
		public override bool CanRoll(Item item)
		{
			return true;
		}

        public override void ApplyAccessoryEffects(Player player)
        {
			player.lifeRegen += 2;
			player.lifeRegen =(int)(player.lifeRegen*1.25f);
        }

        public override void ModifyValue(ref float valueMult)
		{
			valueMult*=1f+0.01f*Power;
		}

		public override void Apply(Item item)
		{

		}

	}
    public class 回复二 : ModPrefix
    {
        public override void SetStaticDefaults()
        {


        }

        public virtual float Power => 1.25f;
        public override PrefixCategory Category => PrefixCategory.Accessory;

        public override float RollChance(Item item)
        {
            return 3f;
        }

        public override bool CanRoll(Item item)
        {
            return true;
        }

        public override void ApplyAccessoryEffects(Player player)
        {
            player.lifeRegen += 4;
            player.lifeRegen = (int)(player.lifeRegen * 1.45f);
        }

        public override void ModifyValue(ref float valueMult)
        {
            valueMult *= 1f + 0.1f * Power;
        }

        public override void Apply(Item item)
        {

        }

    }
}