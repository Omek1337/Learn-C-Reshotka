using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeMeACoffee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello customer!");
            Console.WriteLine("We have two coffee machines.");
            Console.WriteLine("Choose wisely!");
            Console.WriteLine("Enter number of the machine(1 or 2)");
            int coffeeNum;
            try
            {
                coffeeNum = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                InvalidInput();
                throw;
            }
            if (coffeeNum < 3 && coffeeNum > 0)
            {
                switch (coffeeNum)
                {
                    case 1:
                        Philips3200 cm1 = new Philips3200();
                        cm1.MakeDecision(cm1.GiveMenu());

                        break;
                    case 2:
                        RussellHobbs2000 cm2 = new RussellHobbs2000();
                        cm2.MakeDecision(cm2.GiveMenu());
                        break;
                    default:
                        break;
                }
            }
            else InvalidInput();
        }

        public static void InvalidInput() 
        {
            Console.WriteLine("Invalid input");
            Console.ReadLine();
            Environment.Exit(0);
        }

    }
}
