using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Rectangle r = new Rectangle(a,b);
            Triangle t = new Triangle(a,b,c);
            List<IShape> s = new List<IShape>();
            s.Add(r);
            s.Add(t);
            foreach (var item in s)
            {

                Console.WriteLine($"P = {item.GetP()}");
                Console.WriteLine($"S = {item.GetS()}");
            }
            
            Console.ReadLine();
            
        }
    }
}
