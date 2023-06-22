using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBlend
{
    public static class Transfer
    {
        public static List<Tank> Trasfer(Tank[] source, Tank target, List<Tank> Tanks)
        {
            foreach (var tank in Tanks)
            {
                if (tank.id == target.id)
                {
                    tank.ratios = ConsiderResult.CalculateResult(source);
                    break;
                }
            }

            foreach (var tank in Tanks)
            {
                foreach(Tank t in source)
                {
                    if (tank.id == t.id)
                    {
                        tank.ratios = Enumerable.Repeat(0.0, tank.ratios.Length).ToArray();
                        tank.ratios[0] = 1;
                        break;
                    }
                }
            }

            return Tanks;
        }
    }
}
