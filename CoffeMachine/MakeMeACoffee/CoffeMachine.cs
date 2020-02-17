using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeMeACoffee
{
    abstract class CoffeMachine : ICoffeMachine
    {
        public void AddChocolate()
        {
            Console.WriteLine("Adding chocolate...");
        }

        public void AddTeaBag(bool isGreen)
        {
            if (isGreen)
            {
                Console.WriteLine("Adding green tea bag...");
            } else Console.WriteLine("Adding black tea bag...");

        }

        public void PourCoffee()
        {
            Console.WriteLine("Pouring espresso shot...");
        }

        public void PourHotWater()
        {
            Console.WriteLine("Pouring hot water...");
        }

        public void PourMilk(bool moreMilk)
        {
            if (moreMilk)
            {
                Console.WriteLine("Pouring more milk...");
            }else Console.WriteLine("Pouring less milk...");

        }
        public virtual int GiveMenu()
        {
            Console.WriteLine("Here's the menu: ");
            return 1;
        }
        public virtual void MakeDecision(int chosenDrink) 
        {
            Console.WriteLine("Enjoy your drink!");
            Console.ReadLine();
        }
    }
}
