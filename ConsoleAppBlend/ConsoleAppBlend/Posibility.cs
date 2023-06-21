using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBlend
{
    public static class Posibility
    {
        // Find all the posible combinason of transfere
        public static List<Tank[]> BuildPoibility(List<Tank> Tanks)
        {
            List<Tank[]> PoibilityList = new List<Tank[]>();
            var full = GetFullTanks(Tanks);

            Tank[] tankArr = full.ToArray();
            foreach (Tank tank in Tanks)
            {
                if (tank.varieties.Contains("") && tank.ratios[0] == 1)
                {
                    var sol = CombinationSum(tankArr, tank.capacity);
                    foreach (IList<Tank> list in sol)
                    {
                        Tank[] arr = list.ToArray();
                        if (!PoibilityList.Contains(arr))
                        {
                            PoibilityList.Add(arr);
                        }
                    }
                }
            }

            return PoibilityList;
        }

        private static List<Tank> GetFullTanks (List<Tank> Tanks) {
            List<Tank> List = new List<Tank>();

            foreach (Tank tank in Tanks)
            {
                if (!(tank.varieties.Contains("") && tank.ratios[0] == 1))
                {
                    List.Add(tank);
                }
            }

            return List;
        }

        private static IList<IList<Tank>> CombinationSum(Tank[] candidates, int target)
        {
            IList<IList<Tank>> answer = new List<IList<Tank>>();
            int total = 0;
            int i = 0;
            List<Tank> current = new List<Tank>();
            Array.Sort(candidates, new TankComparer());
            backtracking(answer, current, i, total, target, candidates);
            return answer;
        }

        private static void backtracking(IList<IList<Tank>> answer, List<Tank> current, int i, int total, int target, Tank[] candidates)
        {
            if (total == target)
            {
                answer.Add(new List<Tank>(current));
                return;
            }
            if (total > target)
            {
                return;
            }
            if (i == candidates.Length)
            {
                return;
            }
            current.Add(candidates[i]);
            total = total + candidates[i].capacity;
            backtracking(answer, current, i + 1, total, target, candidates);
            current.RemoveAt(current.Count - 1);
            total = total - candidates[i].capacity;
            while ((i + 1) < candidates.Length && candidates[i] == candidates[i + 1])
            {
                i = i + 1;
            }
            backtracking(answer, current, i + 1, total, target, candidates);
        }

        private class TankComparer : IComparer<Tank>
        {
            public int Compare(Tank x, Tank y)
            {
                return x.capacity.CompareTo(y.capacity);
            }
        }
    }
}
