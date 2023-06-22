using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace ConsoleAppBlend
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            EraseOutput(@"../../output.txt");

            //Declare the Formula before the tanks
            ReadCSV.ReadFormula(@"../../formula.csv");

            //Declare the tanks (number, size, wine type)
            ReadCSV.ReadTanks(@"../../tank.csv");

            MeasureExecutionTime(() => WineBlending.Blend(@"../../output.txt"));

            Console.ReadLine();
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

        static void EraseOutput(string path)
        {
            File.Delete(path);
        }
    }
}
