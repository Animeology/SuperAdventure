namespace Engine
{
    public class LivingCreature
    {
        public LivingCreature(int currentHP, int maxHP)
        {
            CurrentHP = currentHP;
            MaxHP = maxHP;
        }

        public int CurrentHP { get; set; }
        public int MaxHP { get; set; }

    }
}
