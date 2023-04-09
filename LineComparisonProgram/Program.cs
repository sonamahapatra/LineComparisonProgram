using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProgram
{
    internal class Program
    {
        double firstLine, secondLine;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Line Comparison Program");
           // LineComp.FindLine();
            LineComp line = new LineComp(3, 4, -2, 3);
            firstLine = line.Calculate();
            LineComp line1 = new LineComp(1, 2, 3, 4);
            secondLine = line1.Calculate();

            //UC-2
            if (firstLine.Equals(secondLine))
            {
                Console.WriteLine("Two lines are Equal");
            }
            else
            {
                Console.WriteLine("Two lines are Not equal");
            }
            Console.ReadLine();
        }
    }
}
