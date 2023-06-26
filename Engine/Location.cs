namespace Engine
{
    public class Location
    {
        public Location(int id, string name, string description)
        {
            ID = id;
            Name = name;
            Description = description;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
