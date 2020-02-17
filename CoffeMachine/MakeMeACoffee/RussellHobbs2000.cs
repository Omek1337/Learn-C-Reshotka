using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeMeACoffee
{
    class RussellHobbs2000 : CoffeMachine
    {
        public void PourWater()
        {
            base.PourHotWater();
        }
        public void MakeEspresso()
        {
            base.PourCoffee();
        }
        public void MakeDoubleEspresso()
        {
            base.PourCoffee();
            base.PourCoffee();
        }
        public void MakeCappuccino() 
        {
            base.PourCoffee();
            base.PourMilk(true); //true ==  more milk
        }
        public void MakeGreenTea()
        {
            base.PourHotWater();
            base.AddTeaBag(false); // false == black tea
        }
        public void MakeMocachino()
        {

            base.PourCoffee();
            base.AddChocolate();

        }
        public override DrinkType GiveMenu() 
        {
            base.GiveMenu();
            Console.WriteLine("1. Water");
            Console.WriteLine("2. Espresso");
            Console.WriteLine("3. Double Espresso");
            Console.WriteLine("4. Cappuccino");
            Console.WriteLine("5. Green Tea");
            Console.WriteLine("6. Mocachino");
            int chosenDrinkNum = int.Parse(Console.ReadLine());
            DrinkType chosenDrink;
            chosenDrink = (chosenDrinkNum == 1) ? DrinkType.Water : DrinkType.Water;
            chosenDrink = (chosenDrinkNum == 2) ? DrinkType.Espresso : DrinkType.Water;
            chosenDrink = (chosenDrinkNum == 3) ? DrinkType.DoubleEspresso : DrinkType.Water;
            chosenDrink = (chosenDrinkNum == 4) ? DrinkType.Cappuccino : DrinkType.Water;
            chosenDrink = (chosenDrinkNum == 5) ? DrinkType.GreenTea : DrinkType.Water;
            chosenDrink = (chosenDrinkNum == 6) ? DrinkType.Mocachino : DrinkType.Water;
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
                case DrinkType.DoubleEspresso:
                    MakeDoubleEspresso();
                    break;
                case DrinkType.Cappuccino:
                    MakeCappuccino();
                    break;
                case DrinkType.GreenTea:
                    MakeGreenTea();
                    break;
                case DrinkType.Mocachino:
                    MakeMocachino();
                    break;
                default:
                    Console.WriteLine("Invalid Input.");
                    break;
            }
            base.MakeDecision(0);
        }
    }
}
