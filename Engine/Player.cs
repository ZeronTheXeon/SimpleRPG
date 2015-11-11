namespace Engine
{
    public class Player : LivingThing
    {
        public int CurrentMP { get; set; }
        public int MaxMP { get; set; }
        public int Money { get; set; }
        public int Level { get; set; }
        public int ExperiencePoints { get; set; }

        public string Location { get; set; }

        public Player(int currentHitPoints, int maximumHitPoints, int currentMP, int maxMP, int money, int experiencePoints, int level) : base(currentHitPoints, maximumHitPoints)
        {
            Money = money;
            ExperiencePoints = experiencePoints;
            Level = level;
            CurrentMP = currentMP;
            MaxMP = maxMP;
        }
    }
}