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
                        Philips3200 phillips = new Philips3200();
                        phillips.MakeDecision(phillips.GiveMenu());

                        break;
                    case 2:
                        RussellHobbs2000 russell = new RussellHobbs2000();
                        russell.MakeDecision(russell.GiveMenu());
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
