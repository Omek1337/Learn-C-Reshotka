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
            DrinkType chosenDrink = DrinkType.Water;
            if (chosenDrinkNum == 1) chosenDrink = DrinkType.Water;
            else if (chosenDrinkNum == 2) chosenDrink = DrinkType.Espresso;
            else if (chosenDrinkNum == 3) chosenDrink = DrinkType.DoubleEspresso;
            else if (chosenDrinkNum == 4) chosenDrink = DrinkType.Cappuccino;
            else if (chosenDrinkNum == 5) chosenDrink = DrinkType.GreenTea;
            else if (chosenDrinkNum == 6) chosenDrink = DrinkType.Mocachino;

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
