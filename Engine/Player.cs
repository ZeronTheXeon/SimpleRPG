using System.Collections.Generic;
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

        public List<InventoryItem> Inventory { get; set; }
        public List<PlayerQuest> Quests { get; set; }


        public Player(int currentHitPoints, int maximumHitPoints, int currentMP, int maxMP, int money, int experiencePoints, int level) : base(currentHitPoints, maximumHitPoints)
        {
            Money = money;
            ExperiencePoints = experiencePoints;
            Level = level;
            CurrentMP = currentMP;
            MaxMP = maxMP;
            Inventory = new List<InventoryItem>();
            Quests = new List<PlayerQuest>();
        }
    }
}