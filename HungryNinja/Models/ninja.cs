using System;
using System.Collections.Generic;

namespace hungryNinja.Models
{
    class Ninja
    {
        // add a constructor
        private int calorieIntake;
        public int calorieAmount
        {
            get
            {
                return calorieIntake;
            }
        }

        public List<Food> FoodHistory;
        public Ninja(int cal)
        {
            this.calorieIntake = 0;
            this.FoodHistory = new List<Food>() { };
        }

        // add a public "getter" property called "IsFull"
        public bool IsFull {
            get {
                return calorieIntake >= 450;
            }
        }
        
        // build out the Eat method
        public void Eat(Food item)
        {
            if (this.IsFull ==true)
            {
                Console.WriteLine($"Time to have a Ninja Nap, should be avoided when operating heavy machinery");
            }
            else 
            {
                Console.WriteLine($"Ninja will eat {item.Name}.");
                this.calorieIntake += item.Calories;
                this.FoodHistory.Add(item);
                Console.WriteLine($"Dish -> {item.Name}: Spicy? {item.IsSpicy}, Sweet? {item.IsSweet}. {item.Name} has {this.calorieIntake} calories. Ninja has eaten {this.calorieAmount} calories.");
            }
        }
    }
}
