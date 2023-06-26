namespace Engine
{
    public class Weapon : Item
    {
        public Weapon(int id, string name, string namePlural, int minDamage, int maxDamage) 
            : base(id, name, namePlural)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }

        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

    }
}
