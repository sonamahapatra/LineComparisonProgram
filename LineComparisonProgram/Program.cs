using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProgram
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Line Comparison Program");
           
            Line line = new Line(1, 2, 3, 4);
            double length1 = line.Length();
            Console.WriteLine("Length of 1st Line : " + length1);

            Line line2 = new Line(5, 6, 7, 9);
            double length2 = line2.Length();
            Console.WriteLine("Length of 2nd Line : " + length2);

            if (length1.Equals(length2))
            {
                Console.WriteLine("Both Line Are Equal");
            }
            else
            {
                Console.WriteLine("Both Line Are not Equal");
            }
            Console.ReadLine();
            
        }
    }
}
