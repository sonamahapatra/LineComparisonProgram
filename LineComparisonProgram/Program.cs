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
            line.Length();
            Console.ReadLine();
            
        }
    }
}
