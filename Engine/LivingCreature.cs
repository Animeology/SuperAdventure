namespace Engine
{
    public class LivingCreature
    {
        public int CurrentHP { get; set; }
        public int MaxHP { get; set; }
        public LivingCreature(int currentHP, int maxHP)
        {
            CurrentHP = currentHP;
            MaxHP = maxHP;
        }
    }
}
