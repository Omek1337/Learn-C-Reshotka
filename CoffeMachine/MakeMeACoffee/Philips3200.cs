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
        public override int GiveMenu()
        {
            base.GiveMenu();
            Console.WriteLine("1. Water");
            Console.WriteLine("2. Espresso");
            Console.WriteLine("3. Latte");
            Console.WriteLine("4. Black Tea");
            Console.WriteLine("5. Americano");

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
                    MakeLatte();
                    break;
                case 4:
                    MakeBlackTea();
                    break;
                case 5:
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
