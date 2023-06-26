namespace Engine
{
    public class Player : LivingCreature
    {
        public Player(int currentHp, int maxHP, int gold, int experiencePoints, int level)
            : base(currentHp, maxHP)
        {
            Gold = gold;
            ExperiencePoints = experiencePoints;
            Level = level;
        }

        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }

    }
}
