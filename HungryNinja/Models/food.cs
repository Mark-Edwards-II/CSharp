using System;

namespace hungryNinja.Models
{
    class Food
    {
        public string Name;
        public int Calories;
        public bool IsSpicy; 
        public bool IsSweet; 
        public Food (string name, int cal, bool spicy, bool sweet)
        {
            this.Name = name;
            this.Calories = cal;
            this.IsSpicy = spicy;
            this.IsSweet = sweet;
        }
    }
}