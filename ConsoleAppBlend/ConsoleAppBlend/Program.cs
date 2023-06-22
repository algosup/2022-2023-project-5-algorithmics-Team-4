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
            string[] varieties = { "A", "B" };
            double[] ratios = { 0.8, 0.4 };
            WineBlending.SetFormula(varieties, ratios);

            //Declare the tanks (number, size, wine type)
            WineBlending.SetTanks(1, 100);
            WineBlending.SetTanks(1, 80, "A");
            WineBlending.SetTanks(1, 20, "B");

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
