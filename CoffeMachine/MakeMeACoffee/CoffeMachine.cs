using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeMeACoffee
{
    enum DrinkType
    {
        Water,
        Espresso,
        DoubleEspresso,
        Latte,
        BlackTea,
        GreenTea,
        Americano,
        Cappuccino,
        Mocachino
    }
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
        public virtual DrinkType GiveMenu()
        {
            Console.WriteLine("Here's the menu: ");
            return DrinkType.Water;
        }
        public virtual void MakeDecision(DrinkType chosenDrink) 
        {
            Console.WriteLine("Enjoy your drink!");
            Console.ReadLine();
        }
    }
}
