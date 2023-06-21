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
            MeasureExecutionTime(() => WineBlending.SetTanks(1, 100));
            MeasureExecutionTime(() => WineBlending.SetTanks(1, 80, "A"));
            MeasureExecutionTime(() => WineBlending.SetTanks(1, 20, "B"));

            string[] varieties = { "A", "B" };
            double[] ratios = { 0.8, 0.2 };

            MeasureExecutionTime(() => WineBlending.SetFormula(varieties, ratios));

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
