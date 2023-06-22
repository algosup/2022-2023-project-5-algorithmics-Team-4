using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBlend
{
    // Describe a tank
    public class Tank
    {
        public int capacity { get; set; } // How much wine can the tank hold
        public int quantity { get; set; } // How much does it hold currently (for transfer stage)
        public string[]? varieties { get; set; } // Names of the wines currently in the tanks
        public double[]? ratios { get; set; } // Current ratio of the wines in the tanks
        public int id { get; set; } // Unique tank identifier
    }

    // describe the target formula
    public class FormulaClass
    {
        public string[]? varieties { get; set; } // Names of the wines
        public double[]? ratios { get; set; } // Ratio of the wines
    }

    public class WineBlending
    {
        // Set the blending tanks with their capacity
        // Blending are initially empty tanks
        static List<Tank> Tanks = new List<Tank>();
        static FormulaClass Formula = new FormulaClass();
        static Double BestAccuracy = 1;

        // Set the wine tanks with their capacity, quantity and variety
        // Wine Tanks are initially full tanks
        public static void SetTanks(int number, int capacity, string variety = "", double ratio = 1, bool debug = false)
        {
            // Need to be converted to array
            double[] ratioArr = Enumerable.Repeat(0.0, Formula.ratios.Length + 1).ToArray();

            ratioArr[0] = ratio;
            for (int i = 0; i < ratioArr.Length - 1; i++) {
                if (Formula.varieties[i] == variety)
                {
                    ratioArr[i + 1] = ratio;
                    ratioArr[0] = 0;
                    break;
                }
            }

            string[] varietyArr = Formula.varieties.ToList().Prepend("").ToArray();

            for (int i = 0; i < number; i++)
            {
                Tank tank = new Tank { capacity = capacity, quantity = capacity, varieties = varietyArr, ratios = ratioArr, id=Tanks.Count+1 };
                Tanks.Add(tank);
            };

            if (debug)
            {
                // for debug
                foreach (Tank Tank in Tanks)
                {
                    Console.WriteLine("quantity of N°" + Tank.id + " Tank: " + Tank.quantity);
                    Console.WriteLine("capacity of N°" + Tank.id + " Tank: " + Tank.capacity);
                    Console.WriteLine("variety of N°" + Tank.id + " Tank: " + Tank.varieties[0]);
                    Console.WriteLine("ratio of N°" + Tank.id + " Tank: " + Tank.ratios[0]);
                }

                Console.WriteLine("///////////////////////////");
            }
        }

        public static void SetFormula(string[] varieties, double[] ratios, bool debug = false)
        {
            Formula = new FormulaClass { ratios = ratios, varieties = varieties };

            if (debug)
            {
                for(int i = 0; i<Formula.ratios.Length; i++)
                {
                    Console.WriteLine($"Formula has {Formula.ratios[i]} of {Formula.varieties[i]}");
                }

                Console.WriteLine("///////////////////////////");
            }
        }

        // New blend method
        public static void Blend()
        {
            while (BestAccuracy > 0.1)
            {
                var best = FindBestPosibility();
                PrintInstruction(best.Item1, best.Item2);
                Tanks = Transfer.Trasfer(best.Item1, best.Item2, Tanks);
            }
        }

        private static (Tank[], Tank) FindBestPosibility(bool debugPosiblity = false, bool debugConsider = false)
        {
            var posiblities = Posibility.BuildPoibility(Tanks);
            if (posiblities.Item1.Count == 0)
                throw new Exception("no posible combinasion could be found");

            double[] Acuracy = new double[posiblities.Item1.Count];

            for (int i = 0; i < Acuracy.Length; i++)
            {
                Acuracy[i] = ConsiderResult.Consider(posiblities.Item1[i], Formula);
            }

            var BestSource = posiblities.Item1[Array.IndexOf(Acuracy, Acuracy.Max())];
            var BestTarget = posiblities.Item2[Array.IndexOf(Acuracy, Acuracy.Max())];
            BestAccuracy = Acuracy.Max();

            if (debugPosiblity)
            {
                foreach (var posibility in posiblities.Item1)
                {
                    foreach (var a in posibility)
                    {
                        Console.Write(a.id + " ");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }

            return (BestSource, BestTarget);
        }

        private static void PrintInstruction(Tank[] source, Tank target)
        {
            foreach (Tank tank in source)
            {
                Console.WriteLine($"Transfere from tank N°{tank.id} to tank N°{target.id}");
            }
        }
    }
}





