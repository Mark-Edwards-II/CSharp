using System;

namespace WizardNinjaSamurai.Models
{
    class Wizard : Human
    {
    
        public Wizard (string name) : base (name)
        {
            SetHealth(50);
            Intelligence = 25; // Wizard should have a default health of 50 and Intelligence of 25
        }

        public override int Attack(Human target)
        {
            Console.WriteLine($"{Name} has {Health} health and {target.Name} has {target.Health} health.");
            int dmg = Intelligence * 5;
            target.applydamage(dmg);
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            healingMagic(dmg);
            Console.WriteLine($"{Name} now has {Health} health and {target.Name} now has {target.Health} health and {target.Intelligence} intelligence.");
            return target.Health;
        }

        public void Heal(Human target)
        {
            int heals = target.Intelligence * 10;
            target.healingMagic(heals); 
            Console.WriteLine($"{Name} has healed {target.Name}, and health is now {target.Health} ");
        }
    }
}
