using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeMeACoffee
{
    class Philips3200 : CoffeMachine
    {
        public void PourWater()
        {
            base.PourHotWater();
        }
        public void MakeEspresso()
        {
            base.PourCoffee();
        }
        public void MakeLatte()
        {
            base.PourCoffee();
            base.PourMilk(false);// false == less milk
        }
        public void MakeBlackTea()
        {
            base.PourHotWater();
            base.AddTeaBag(true); // true ==  green tea bag
        }
        public void MakeAmericano()
        {
            base.PourCoffee();
            base.PourHotWater();

        }
        public override DrinkType GiveMenu()
        {
            base.GiveMenu();
            Console.WriteLine("1. Water");
            Console.WriteLine("2. Espresso");
            Console.WriteLine("3. Latte");
            Console.WriteLine("4. BlackTea");
            Console.WriteLine("5. Americano");
            int chosenDrinkNum = int.Parse(Console.ReadLine());
            DrinkType chosenDrink = DrinkType.Water;
            if (chosenDrinkNum == 1) chosenDrink = DrinkType.Water;
            else if (chosenDrinkNum == 2) chosenDrink = DrinkType.Espresso;
            else if (chosenDrinkNum == 3) chosenDrink = DrinkType.Latte;
            else if (chosenDrinkNum == 4) chosenDrink = DrinkType.BlackTea;
            else if (chosenDrinkNum == 5) chosenDrink = DrinkType.Americano;
    
            return chosenDrink;
        }

        public override void MakeDecision(DrinkType chosenDrink)
        {
            switch (chosenDrink)
            {
                case DrinkType.Water:
                    PourWater();
                    break;
                case DrinkType.Espresso:
                    MakeEspresso();
                    break;
                case DrinkType.Latte:
                    MakeLatte();
                    break;
                case DrinkType.BlackTea:
                    MakeBlackTea();
                    break;
                case DrinkType.Americano:
                    MakeAmericano();
                    break;
                default:
                    Console.WriteLine("Invalid Input.");
                    break;
            }
            base.MakeDecision(0);
        }
    }
}
