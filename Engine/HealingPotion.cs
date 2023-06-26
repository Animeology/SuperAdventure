namespace Engine
{
    public class HealingPotion : Item
    {
        public HealingPotion(int id, string name, string namePlural, int amount) 
            : base(id, name, namePlural)
        {
            AmountToHeal = amount;
        }

        public int AmountToHeal { get; set; }

    }
}
