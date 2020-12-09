using System;


namespace WizardNinjaSamurai.Models
{
    class Ninja : Human
    {
    
        public Ninja (string name) : base (name)
        {
            Dexterity = 175; //Ninja should have a default dexterity of 175
        }

// Provide an override Attack method to Ninja, which reduces the target by 5 * Dexterity and a 20% chance of dealing an additional 10 points of damage.
        public override int Attack( Human target )
        {
            Random rand = new Random();
            int chance = rand.Next( 0, 100 );
            int dmg;
            if( chance < 20 )
            {
                dmg = 5 * target.Dexterity + 10;

            }
            else{
                dmg = 5 * target.Dexterity;

            }
            target.Dexterity -= dmg;
            Console.WriteLine($"{ Name } attacked { target.Name } for { dmg } happiness, now they have { target.Dexterity }");
            return target.Dexterity;
        }
        public void Steal(Human target)
        {
            int dmg = 5;
            target.applydamage( dmg );
            SetHealth( Health + 5);
        }
    }
}