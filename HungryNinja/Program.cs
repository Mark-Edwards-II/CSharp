using System;
using hungryNinja.Models;

namespace hungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet oldCountry = new Buffet();
            Ninja Dave = new Ninja(450);
            while (Dave.IsFull == false)
            {
                Dave.Eat(oldCountry.Serve());
            }
        }
    }
}
