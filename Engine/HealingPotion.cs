namespace Engine
{
    public class HealingPotion : Item
    {
        public int AmountToHeal { get; set; }
        public HealingPotion(int id, string name, string namePlural, int amount) 
            : base(id, name, namePlural)
        {
            AmountToHeal = amount;
        }
    }
}
