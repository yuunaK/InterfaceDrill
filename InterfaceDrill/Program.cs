using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDrill
{
    class Program
    {
        interface ElementaryMathOperationsInterface
        {
            int AdditionOperation(int x, int y);
            int SubtractionOperation(int p, int q);
            int MultiplicationOperation(int r, int t);
            int DivisionOperation(int s, int v);
        }

        public class ElementaryMathOperationsImplementation : ElementaryMathOperationsInterface
        {
            public int AdditionOperation(int x, int y)
            {
                int sum = x + y;
                return sum;
            }
            public int SubtractionOperation(int p, int q)
            {
                int difference = p - q;
                return difference;
            }
            public int MultiplicationOperation(int r, int t)
            {
                int product = r * t;
                return product;
            }
            public int DivisionOperation(int s, int v)
            {
                int quotient = s / v;
                return quotient;
            }
        }



        static void Main(string[] args)
        {
            int a, b;
            a = 6;
            b = 2;
            ElementaryMathOperationsImplementation g = new InterfaceDrill.Program.ElementaryMathOperationsImplementation();
            int sum1 = g.AdditionOperation(a, b);
            int difference1 = g.SubtractionOperation(a, b);
            int product1 = g.MultiplicationOperation(a, b);
            int quotient1 = g.DivisionOperation(a, b);

            System.Console.WriteLine("Given two integers, 6 and 2, ");
            System.Console.WriteLine("The sum of 6 and 2 is {0}. ", sum1);
            System.Console.WriteLine("The difference of 6 and 2 is {0}. ", difference1);
            System.Console.WriteLine("The product of 6 and 2 is {0}. ", product1);
            System.Console.WriteLine("The quotient of 6 and 2 is {0}. ", quotient1);

            System.Console.ReadKey(true);






        }
    }
}
