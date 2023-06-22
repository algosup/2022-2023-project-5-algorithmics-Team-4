using System;
using System.Diagnostics;
using System.Linq;

namespace ConsoleAppBlend
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            //Declare the Formula before the tanks
            ReadCSV.ReadFormula(@"../../../../../formula.csv");

            //Declare the tanks (number, size, wine type)
            ReadCSV.ReadTanks(@"../../../../../tank.csv");

            MeasureExecutionTime(() => WineBlending.Blend());
        }

        static void MeasureExecutionTime(Action action)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            action.Invoke();
            stopwatch.Stop();
            Console.WriteLine("Execution time: " + stopwatch.ElapsedMilliseconds + " ms");
            Console.WriteLine();
        }
    }
}
