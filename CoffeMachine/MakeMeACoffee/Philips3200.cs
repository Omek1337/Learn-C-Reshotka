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
            DrinkType chosenDrink;
            chosenDrink = (chosenDrinkNum == 1) ? DrinkType.Water : DrinkType.Water;
            chosenDrink = (chosenDrinkNum == 2) ? DrinkType.Espresso : DrinkType.Water;
            chosenDrink = (chosenDrinkNum == 3) ? DrinkType.Latte : DrinkType.Water;
            chosenDrink = (chosenDrinkNum == 4) ? DrinkType.BlackTea : DrinkType.Water;
            chosenDrink = (chosenDrinkNum == 5) ? DrinkType.Americano : DrinkType.Water;
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
