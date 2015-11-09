namespace Engine
{
    public class Player : LivingThing
    {
        public int CurrentMP { get; set; }
        public int MaxMP { get; set; }
        public int Money { get; set; }
        public int Level { get; set; }

        public string Location { get; set; }
    }
}