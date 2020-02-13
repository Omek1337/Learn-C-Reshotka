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
                    m.SwapNum();
                    break;
                case 5:
                    m.getFibonacci();
                    break;
            }
            Console.Read();
        }
        
    }


}
