using System;
using HumanAssign.Models;


namespace HumanAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Dude = new Human("The Dude");
            Human guy = new Human("Guy",5,10,12,100);
            Console.WriteLine(Dude.Name);
            Console.WriteLine(guy.Name);
            Dude.Attack(guy);
        }
    }
}
