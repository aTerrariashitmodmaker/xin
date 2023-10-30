using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Terraria.ModLoader.IO;
using 新.Buffs;




namespace 新
{
	public class 全局NPC : GlobalNPC //这是一个全局物品的示例
	{
		public bool dll = false;
		public bool dl = false; 
		public bool shouji = false;
	    public bool shouji1 = false;
		public bool shizi = false;
		public int S = 0;
        public int 杀人戒 = 0;
		
        public override bool InstancePerEntity
        {
            get
            {
                return true;
            }
        }
        public override void ResetEffects(NPC npc)
        {
			
			dll = false;
            dl = false;
            shouji = false;
			shouji1 = false;
			shizi = false;
        }
        
        
        public override void UpdateLifeRegen(NPC npc, ref int damage)
        {
            if (dl)
            {
                npc.lifeRegen -= 50;
            }
            if (dll)
            {
				npc.lifeRegen -= 75;
                if (damage<2)
                {
					damage = 3;
                }
            }
            
            if (shouji)
            {
				npc.lifeRegen -= 10000; 
                if (damage < 998)
                {
                    damage = 999;
                }
            }
            if (shouji1)
            {
                npc.lifeRegen -= 10000000; 
                if (damage < 999998)
                {
                    damage = 999999;
                }
            }
            if (shizi)
            {
                npc.lifeRegen -= 300;
                if (damage < 14)
                {
                    damage = 15;
                }
            }
            base.UpdateLifeRegen(npc, ref damage);
        }
        public override void OnKill(NPC npc)
        {
           
        }
        public override void EditSpawnRate(Player player, ref int spawnRate, ref int maxSpawns)
        {
            if (player.HasBuff(BuffID.Battle))
            {
                spawnRate =(int)(spawnRate*0.1) ;
                maxSpawns += 60;
            }
            base.EditSpawnRate(player, ref spawnRate, ref maxSpawns);
        }
    }
}	