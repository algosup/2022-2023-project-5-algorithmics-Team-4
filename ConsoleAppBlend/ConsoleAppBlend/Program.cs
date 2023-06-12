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
            // MeasureExecutionTime(() => Blender.Blending());
            MeasureExecutionTime(() => WineBlending.SetBlendingTanks(100, 200));
            MeasureExecutionTime(() => WineBlending.SetWineTanks(100, 200, "A", 0.5));
           /* MeasureExecutionTime(() => WineBlending.SetRatio(0.5, "A"));*/
            MeasureExecutionTime(() => WineBlending.SetWineTanks(100, 300, "B",0.3));
           
           /* MeasureExecutionTime(() => WineBlending.SetRatio(0.2, "B"));*/
            MeasureExecutionTime(() => WineBlending.SetWineTanks(100, 300, "C", 0.2));
           /* MeasureExecutionTime(() => WineBlending.SetRatio(0.3, "C"));*/
            MeasureExecutionTime(() => WineBlending.Blend());
            MeasureExecutionTime(() => WineBlending.Save());
            


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
