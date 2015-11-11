﻿namespace Engine
{
    public class HealthPotion : Item
    {
        public int AmountToHeal { get; set; }

        public HealthPotion(int id, string name, string namePlural, int amountToHeal) : base(id, name, namePlural)
        {
            AmountToHeal = amountToHeal;
        }
    }
}