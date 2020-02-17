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
        public override int GiveMenu() 
        {
            base.GiveMenu();
            Console.WriteLine("1. Water");
            Console.WriteLine("2. Espresso");
            Console.WriteLine("3. Double Espresso");
            Console.WriteLine("4. Cappuccino");
            Console.WriteLine("5. Green Tea");
            Console.WriteLine("6. Mocachino");
            return int.Parse(Console.ReadLine());
        }

        public override void MakeDecision(int chosenDrink)
        {
            switch (chosenDrink)
            {
                case 1:
                    PourWater();
                    break;
                case 2:
                    MakeEspresso();
                    break;
                case 3:
                    MakeDoubleEspresso();
                    break;
                case 4:
                    MakeCappuccino();
                    break;
                case 5:
                    MakeGreenTea();
                    break;
                case 6:
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
