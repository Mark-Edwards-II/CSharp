using System;
using WizardNinjaSamurai.Models;

namespace WizardNinjaSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Ninja ninja1 = new Ninja("Ninja Hanzo");
            Wizard wizard1 = new Wizard("Wizard Merlin");
            Samurai samurai1 = new Samurai("Samurai Tomoe");
            Ninja ninja2 = new Ninja("Ninja Kotaro");
            wizard1.Attack(ninja1);
            wizard1.Heal(ninja2);
            wizard1.Stats();
            ninja1.Stats();
            ninja1.Steal(samurai1);
            ninja1.Stats();
            samurai1.Stats();
            samurai1.Meditate();
            samurai1.Stats();
            
        }
    } 
}
