namespace Engine
{
    public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Item ItemRequiredToEnter { get; set; }
        public Quest QuestAvailable { get; set; }
        public Monster MonsterLivingHere { get; set; }
        public Location NorthLocation { get; set; }
        public Location EastLocation { get; set; }
        public Location WestLocation { get; set; }    
        public Location SouthLocation { get; set; }
        public Location(int id, string name, string description, 
            Item itemRequired = null, Quest questAvailable = null, Monster monsterLivingHere = null)
        {
            ID = id;
            Name = name;
            Description = description;

            ItemRequiredToEnter = itemRequired;
            QuestAvailable = questAvailable;
            MonsterLivingHere = monsterLivingHere;
        }
    }
}
