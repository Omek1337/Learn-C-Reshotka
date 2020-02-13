using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace excersises2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What program do you want to choose?(1,2,3,4,5)");
            int n = int.Parse(Console.ReadLine());
            Methods m = new Methods();
            switch (n)
            {
                case 1:
                    m.HelloMethod();
                    break;
                case 2:
                   m. SpaceCount();
                    break;
                case 3:
                    m.CalculateElements();
                    break;
                case 4:
                    Console.WriteLine("First number:");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Second number:");
                    int b = int.Parse(Console.ReadLine());
                    m.SwapNum(ref a, ref b);
                    break;
                case 5:
                    Console.WriteLine("Enter a number:");
                    int i = int.Parse(Console.ReadLine());
                    m.getFibonacci(0, 1, 1, i);
                    break;
            }
            Console.Read();
        }
        
    }


}
