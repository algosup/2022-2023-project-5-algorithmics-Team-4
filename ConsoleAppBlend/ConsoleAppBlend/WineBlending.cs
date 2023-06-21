using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBlend
{
    // describe a tank
    public class Tank
    {
        public int capacity { get; set; } //How much wine can the tank hold
        public int quantity { get; set; } //How much does it hold curently (for transfere stage)
        public string[]? varieties { get; set; } //Names of the wines curently in the tanks
        public double[]? ratios { get; set; } //Curent ratio of the wines in the tanks
        public int id { get; set; } //unique tank identifier
    }

    // describe the target formula
    public class FormulaClass
    {
        public string[]? varieties { get; set; } //Names of the wines
        public double[]? ratios { get; set; } //Ratio of the wines
    }

    public class WineBlending
    {
        // Set the blending tanks with their capacity
        // Blending are initialy empty tanks
        static List<Tank> Tanks = new List<Tank>();
        static FormulaClass Formula = new FormulaClass();

        // Set the wine tanks with their capacity, quantity and variety
        // Wine Tanks are initialy full tanks
        public static void SetTanks(int number, int capacity, string variety = "", double ratio = 1, bool debug = false)
        {
            //need to be converted to array
            string[] varietyArr = { variety };
            double[] ratioArr = { ratio };

            for (int i = 0; i < number; i++)
            {
                Tank tank = new Tank { capacity = capacity, quantity = capacity, varieties = varietyArr, ratios = ratioArr, id=Tanks.Count+1 };
                Tanks.Add(tank);
            };

            if (debug)
            {
                // for debug
                var trig = 0;
                foreach (Tank Tank in Tanks)
                {
                    trig++;
                    Console.WriteLine("quantity of N°" + trig + " Tank: " + Tank.quantity);
                    Console.WriteLine("capacity of N°" + trig + " Tank: " + Tank.capacity);
                    Console.WriteLine("variety of N°" + trig + " Tank: " + Tank.varieties);
                    Console.WriteLine("ratio of N°" + trig + " Tank: " + Tank.ratios);
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
            foreach (Tank tank in Tanks)
            {

            }
        }

        // New save method
        public static void Save()
        {

        }
    }
}





