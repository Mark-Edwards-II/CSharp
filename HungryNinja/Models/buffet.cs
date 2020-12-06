using System;
using System.Collections.Generic;

namespace hungryNinja.Models
{
    class Buffet
    {
        public List<Food> Menu;
        public static Random rand = new Random();
     
    //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Maguro Sashimi", 80, false, false),
                new Food("Nama Sake Sashimi", 100, false, false),
                new Food("Unagi Don", 450, false, true),
                new Food("Kajiki Nigiri", 120, false, false),
                new Food("Can You Handle It?", 320, true, false),
                new Food("Devil's Tuna", 400, true, false),
                new Food("Ikura Sashimi", 250, false, true),
            };
        }
     
        public Food Serve()
        {
            return Menu[rand.Next(Menu.Count)];
        }
    }
}
