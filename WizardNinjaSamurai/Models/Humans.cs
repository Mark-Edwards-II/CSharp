using System;

namespace WizardNinjaSamurai.Models
{
    class Human
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

        public void SetHealth(int hp)
        // There is a call back to set health in Wizard.
        {
            health = hp;
        }

        public Human(string name)
        {
            Name = name;
            Strength=3;
            health=100;
            Intelligence=3;
            Dexterity=3;
        }

        public Human(string n, int hp, int str, int intl, int dex)
        {
            Name=n;
            Strength=str;
            health=hp;
            Intelligence=intl;
            Dexterity=dex;
        }
        // Public=accessable from other classes, Virtual=
        public virtual int Attack(Human target)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{target.Name}'s health is at {target.health}.");
            int dmg = Strength * 3;
            target.applydamage(dmg);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{target.Name}'s been attacked and health is now {target.health} ");
            Console.ResetColor();
            return target.health;
        }
        public void applydamage(int dmg)
        {
            health -= dmg;
        }

        public void healingMagic(int dmg)
        {
            health += dmg;
        }

        public void Stats()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Here are {Name}'s stats:");
            Console.WriteLine($"{Strength} Strength");
            Console.WriteLine($"{Intelligence} Intelligence");
            Console.WriteLine($"{Dexterity} Dexterity");
            Console.WriteLine($"{health} Health");
            Console.ResetColor();
        }
    }
}
