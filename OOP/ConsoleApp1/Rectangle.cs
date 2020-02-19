using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Rectangle : IShape
    {
        public int a,b;

        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public decimal GetS() 
        {
            int S = a * b;
            return S;
        }
        public int GetP()
        {
            int P = (a + b) * 2;
            return P;
        }
    }
}
