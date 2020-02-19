using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Triangle : IShape
    {
        public int a, b, c;

        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public int GetP() 
        {
            int P = (a + b < c || b + c < a || c + a < b) ? 0 : (a + b + c);
                return P;
        }
        public decimal GetS()
        {
            decimal p = (a + b + c) / 2;
            Console.WriteLine(p);
            double s = (double) (p * (p - a) * (p - b) * (p - c));

            return (decimal) Math.Sqrt(s);
        }
    }
}
