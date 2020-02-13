using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excersises2
{
    public class Methods
    {
        public void HelloMethod()
        {
            Console.WriteLine("Welcome firends!");
            Console.WriteLine("Have a nice day!");
        }
        public void SpaceCount()
        {
            Console.WriteLine("Input any sentence you want to count spaces in");
            string str = Console.ReadLine();
            
            int count = 0;
            foreach (char c in str)
                if (c == ' ') count++;
            Console.WriteLine(count);
        }
        public void CalculateElements()
        {
            int[] m = new int[5];
            Console.WriteLine("Input 5 numbers");

            for (int i = 0; i < 5; i++)
            {
                m[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            foreach (var el in m)
            {
                sum += el;
            }
            Console.WriteLine("The sum of the elements int the output is: " + sum);
        }

        public void SwapNum()
        {
            Console.WriteLine("First number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Second number:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Now the first number is {b} and second is {a}");
        }

        public void getFibonacci()
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            int fib = 0;
            int n1 = 1, n2 = 1;
            if (n > 2)
            {
                for (int i = 2; i < n; i++)
                {
                    fib = n1 + n2;
                    n1 = n2;
                    n2 = fib;
                }
            }
            else fib = 1;
            Console.WriteLine($"The fibonacci of {n} is: {fib}");
        }
    }
}
