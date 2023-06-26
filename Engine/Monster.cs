using System.Collections.Generic;

namespace Engine
{
    public class Monster : LivingCreature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaxDamage { get; set; }
        public int RewardXP { get; set; }
        public int RewardGold { get; set; }
        public List<LootItem> LootItems { get; set; }
        public Monster(int currentHp, int maxHP, int id, string name, int maxDamage, int rewardXP, int rewardGold) 
            : base (currentHp, maxHP)
        {
            ID = id;
            Name = name;
            MaxDamage = maxDamage;
            RewardXP = rewardXP;
            RewardGold = rewardGold;
            LootItems = new List<LootItem>();
        }
    }
}
