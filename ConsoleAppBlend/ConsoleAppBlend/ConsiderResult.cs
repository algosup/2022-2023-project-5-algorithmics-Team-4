using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBlend
{
    public static class ConsiderResult
    {
        public static double Consider(Tank[] Tanks, FormulaClass Formula) {
            //Need to add the empty to the formula to make it as long as the Tank
            double[] FormulaPrepend = Formula.ratios.ToList().Prepend(0).ToArray();

            return CalculateEuclideanDistance(CalculateResult(Tanks), FormulaPrepend);
        }

        static private double CalculateEuclideanDistance(double[] array1, double[] array2)
        {
            if (array1.Length != array2.Length)
                throw new ArgumentException("Both arrays should have the same length.");

            double sum = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                sum += Math.Pow(array1[i] - array2[i], 2);
            }

            return Math.Sqrt(sum);
        }

        static public double[] CalculateResult(Tank[] Tanks) {

            Tank totalTank = new Tank();
            double[] combinedRatio = new double[Tanks[0].ratios.Length];

            foreach (Tank Tank in Tanks)
            {
                totalTank.capacity += Tank.capacity;

                for (int i = 1; i < Tank.ratios.Length; i++)
                {
                    combinedRatio[i] += Tank.ratios[i] * Tank.capacity;
                }
            }

            for (int i = 0; i < combinedRatio.Length; ++i)
            {
                combinedRatio[i] = combinedRatio[i] / totalTank.capacity;
            }

            return combinedRatio;
        }
    }
}
