using System;

namespace HumanAssign.Models
{
    public class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        public int Health
        {
            get
            {
                return health;
            }
        }
        public Human(string name, int dexterity, int strength, int intelligence, int hlth)
        {
            Name=name;
            Dexterity=dexterity;
            Strength=strength;
            Intelligence=intelligence;
            health=hlth;
        }
        public Human(string name)
        {
            Name = name;
            this.Strength=3;
            this.health=100;
            this.Intelligence=3;
            this.Dexterity=3;
        }



        public int Attack(Human target)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{target.Name} started with {target.health} health,");
            int dmg = Strength * 5; 
            target.applydamage(dmg);
            Console.WriteLine($"{target.Name}'s been hit and now has {target.health}");
            Console.ResetColor();
            return target.Health;
        }
        public void applydamage(int dmg){
            health -= dmg;
        }
    }
}