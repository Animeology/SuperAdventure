using System.Collections.Generic;

namespace Engine
{
    public class Player : LivingCreature
    {
        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }
        public List<InventoryItem> Inventory { get; set; }
        public List<PlayerQuest> QuestList { get; set; }
        public Location CurrentLocation { get; set; }

        public Player(int currentHp, int maxHP, int gold, int experiencePoints, int level)
            : base(currentHp, maxHP)
        {
            Gold = gold;
            ExperiencePoints = experiencePoints;
            Level = level;
            Inventory = new List<InventoryItem>();
            QuestList = new List<PlayerQuest>();
        }
    }
}
