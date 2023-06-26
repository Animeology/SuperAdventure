namespace Engine
{
    public class Location
    {
        public Location(int id, string name, string description, 
            Item itemRequired, Quest questAvailable, Monster monsterLivingHere)
        {
            ID = id;
            Name = name;
            Description = description;

            itemRequired = null;
            questAvailable = null;
            monsterLivingHere = null;

            ItemRequiredToEnter = itemRequired;
            QuestAvailable = questAvailable;
            MonsterLivingHere = monsterLivingHere;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Item ItemRequiredToEnter { get; set; }
        public Quest QuestAvailable { get; set; }
        public Monster MonsterLivingHere { get; set; }
        public Location NorthLocation { get; set; }
        public Location EastLocation { get; set; }
        public Location WestLocation { get; set; }    
        public Location NestLocation { get; set; }
    }
}
