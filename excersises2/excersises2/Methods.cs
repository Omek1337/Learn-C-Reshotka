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
            Console.WriteLine("Welcome friends!");
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
            int sum = (from el in m
                       select el).Sum();
            Console.WriteLine("The sum of the elements int the output is: " + sum);
        }

        public void SwapNum(ref int a, ref int b)
        {
            Console.WriteLine($"Now the first number is {b} and second is {a}");
        }

        public void getFibonacci(int n1, int n2,int i, int n)
        {
            if (i < n)
            {
                getFibonacci(n2, n1 + n2, i + 1, n);
            }
            Console.WriteLine($"The fibonacci of {i} is: {n1}");
        }
    }
}
