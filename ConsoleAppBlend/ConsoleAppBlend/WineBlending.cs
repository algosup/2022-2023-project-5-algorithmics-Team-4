using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBlend
{
    public class BlendingTank
    {
        internal string variety;
        internal double ratio;

        public int capacity { get; set; }

        public int quantity { get; set; }


    }
    public class WineTank
    {
        public int capacity { get; set; }

        public int quantity { get; set; }
        public string variety { get; set; }

        public double ratio { get; set; }
    }
    /*        data input type:

            variety of wine: … str eg: A B C… (type of wine expected to blend)
            number of blending tanks: … int 1 2 3… (number of tanks to blend in it)
            number of wine tanks: …int 1 2 3… (number of tanks it contain wine)
            ratio of wine: … double 0.0 0.2 0.5…(ratio expected to blend with x variety of wine)
            quantity of tanks: … in 100 200 300…(quantity a wine actually has) 
            capacity of tanks: … int 100 200 300…(quantity a wine can contain at MAX)

            n object blending tank: capacity, quantity
            n object wine tank: capacity, quantity, variety, ratio of variety

            algo process:

            phase 1: blending
            -ratio of x variety of wine to transfert
            -transfert the wine of wine tanks into the blending tank(s)
            -blend into the blending tank(s)
            (depend of the capacity of blending tank(s) and wine tanks, find the best combination to waste the less quantity of wine possible)

            phase 2:save
            -check the remaining quantity of the wine tanks used for the blending process
            -fill the tanks can be full and let the empty tanks if is possible or use it if it permit to waste less quantity possible
        (depend of the main goal, waste less possible or conserve has possible the variety of wine )

            phase 3:done
            - all blending and save process is done
            - waste wine can’t be save*/
    class WineBlending
    {
        // Set the blending tanks with their capacity
        static List<BlendingTank> blendingTanks = new List<BlendingTank>();
        static List<WineTank> wineTanks = new List<WineTank>();
        public static void SetBlendingTanks(int n, int c)
        {
            //List<Tuple<int, int>> blendingTanks = new List<Tuple<int, int>>();
            Console.WriteLine("SetBlendingTanks");

            for (int i = 0; i < n; i++)
            {
                BlendingTank tank = new BlendingTank { capacity = c, quantity = 0 };
                blendingTanks.Add(tank);
            };
            // for debug
            var trig = 0;
            foreach (BlendingTank blendingTank in blendingTanks)
            {
                trig++;
                Console.WriteLine("quantity of N°" + trig + " BlendingTank: " + blendingTank.quantity);
                Console.WriteLine("capacity of N°" + trig + " BlendingTank: " + blendingTank.capacity);
            }

            Console.WriteLine("///////////////////////////");
        }

        // Set the wine tanks with their capacity, quantity and variety 
        public static void SetWineTanks(int n, int q, string v, double r)
        {
            Console.WriteLine("SetWineTanks");
            for (int i = 0; i < n; i++)
            {
                WineTank tank = new WineTank { capacity = q, quantity = q, variety = v, ratio = r };
                wineTanks.Add(tank);
            };

            // for debug
            var trig = 0;
            foreach (WineTank wineTank in wineTanks)
            {
                trig++;
                Console.WriteLine("quantity of N°" + trig + " WineTank: " + wineTank.quantity);
                Console.WriteLine("capacity of N°" + trig + " WineTank: " + wineTank.capacity);
                Console.WriteLine("variety of N°" + trig + " WineTank: " + wineTank.variety);
                Console.WriteLine("ratio of N°" + trig + " WineTank: " + wineTank.ratio);
            }

            Console.WriteLine("///////////////////////////");
        }

        /* public static void SetRatio(double r, string v)
         {
             Console.WriteLine("SetRatio");
             foreach (WineTank WineTank in wineTanks)
             {
                 if (WineTank.variety == v)
                 {
                     WineTank.ratio = r;
                 }
             }
             // for debug
             var trig = 0;
             Console.WriteLine("Time to Ratio!");
             foreach (WineTank wineTank in wineTanks)
             {
                 trig++;
                 Console.WriteLine("quantity of N°" + trig + " WineTank: " + wineTank.quantity);
                 Console.WriteLine("capacity of N°" + trig + " WineTank: " + wineTank.capacity);
                 Console.WriteLine("variety of N°" + trig + " WineTank: " + wineTank.variety);
                 Console.WriteLine("ratio of N°" + trig + " WineTank: " + wineTank.ratio);
             }
             Console.WriteLine("///////////////////////////");
         }*/

        // Old blend method
        /*public static void Blend()
        {
            Console.WriteLine("Blend");
            var varietyRatios = new Dictionary<string, double>();

            // Set variety ratios 
            foreach (WineTank wineTank in wineTanks)
            {
                if (varietyRatios.ContainsKey(wineTank.variety))
                {
                    varietyRatios[wineTank.variety] = wineTank.ratio;
                }
                else
                {
                    varietyRatios.Add(wineTank.variety, wineTank.ratio);
                }
                Console.WriteLine("Ratio of WineTank of " + wineTank.variety + " variety = " + varietyRatios[wineTank.variety]);
            }

            double totalRatio = varietyRatios.Values.Sum(); // Calculate the sum of all ratios

            if (totalRatio == 1.0)
            {
                // Blend the wine from wine tanks into blending tanks
                foreach (BlendingTank blendingTank in blendingTanks)
                {
                    if (blendingTank.quantity < blendingTank.capacity)
                    {
                        foreach (string variety in varietyRatios.Keys)
                        {
                            double ratio = varietyRatios[variety];
                            int transferQuantity = (int)(blendingTank.capacity * ratio);
                            int remainingCapacity = blendingTank.capacity - blendingTank.quantity;

                            if (remainingCapacity >= transferQuantity)
                            {
                                bool isTransferred = false; // Flag to track if a transfer has been made for the current variety

                                foreach (WineTank wineTank in wineTanks)
                                {
                                    if (wineTank.variety == variety && wineTank.quantity >= transferQuantity)
                                    {
                                        wineTank.quantity -= transferQuantity;
                                        blendingTank.quantity += transferQuantity;
                                        Console.WriteLine($"Transferred {transferQuantity} from {wineTank.variety} WineTank to BlendingTank.");
                                        isTransferred = true;
                                        break; // Exit the loop after transferring once per variety
                                    }
                                }

                                if (!isTransferred)
                                {
                                    Console.WriteLine($"Not enough wine in {variety} WineTank, transfer canceled!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Blending tank is full, transfer canceled!");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Blending tank is already full, transfer canceled!");
                    }

                    Console.WriteLine($"Blending tank quantity: {blendingTank.quantity}");
                }
            }
            else
            {
                Console.WriteLine("Invalid ratios. The sum of variety ratios must be 1.0.");
            }
            Console.WriteLine("////////////////////////////////////////////");
        }*/

        // New blend method
        public static void Blend()
        {
            Console.WriteLine("Blend");
            var varietyRatios = new Dictionary<string, double>();
            var wineTankVarieties = new Dictionary<string, List<WineTank>>();

            // Set variety ratios and populate the wineTankVarieties dictionary
            foreach (WineTank wineTank in wineTanks)
            {
                if (varietyRatios.ContainsKey(wineTank.variety))
                {
                    varietyRatios[wineTank.variety] = wineTank.ratio;
                }
                else
                {
                    varietyRatios.Add(wineTank.variety, wineTank.ratio);
                }

                if (wineTankVarieties.ContainsKey(wineTank.variety))
                {
                    wineTankVarieties[wineTank.variety].Add(wineTank);
                }
                else
                {
                    wineTankVarieties.Add(wineTank.variety, new List<WineTank> { wineTank });
                }

                Console.WriteLine("Ratio of WineTank of " + wineTank.variety + " variety = " + varietyRatios[wineTank.variety]);
            }

            double totalRatio = varietyRatios.Values.Sum();

            if (totalRatio == 1.0)
            {
                // Blend the wine from wine tanks into blending tanks
                foreach (BlendingTank blendingTank in blendingTanks)
                {
                    if (blendingTank.quantity < blendingTank.capacity)
                    {
                        foreach (string variety in varietyRatios.Keys)
                        {
                            double ratio = varietyRatios[variety];
                            int transferQuantity = (int)(blendingTank.capacity * ratio);
                            int remainingCapacity = blendingTank.capacity - blendingTank.quantity;

                            if (remainingCapacity >= transferQuantity)
                            {
                                List<WineTank> wineTanksWithVariety = wineTankVarieties[variety];

                                foreach (WineTank wineTank in wineTanksWithVariety)
                                {
                                    if (wineTank.quantity >= transferQuantity)
                                    {
                                        wineTank.quantity -= transferQuantity;
                                        blendingTank.quantity += transferQuantity;
                                        Console.WriteLine($"Transferred {transferQuantity} from {wineTank.variety} WineTank to BlendingTank.");
                                        break; // Exit the loop after transferring once per variety
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Blending tank is full, transfer canceled!");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Blending tank is already full, transfer canceled!");
                    }

                    Console.WriteLine($"Blending tank quantity: {blendingTank.quantity}");
                }
            }
            else
            {
                Console.WriteLine("Invalid ratios. The sum of variety ratios must be 1.0.");
            }

            Console.WriteLine("////////////////////////////////////////////");
        }


        // Old save method
        /*      public static void Save()
              {
                  Console.WriteLine("Save");
                  // Sort the wine tanks by the remaining quantity (in descending order)
                  var sortedWineTanks = wineTanks.OrderByDescending(tank => tank.quantity).ToList();

                  // Iterate through the sorted wine tanks
                  foreach (WineTank wineTank in sortedWineTanks)
                  {
                      if (wineTank.quantity == wineTank.capacity || wineTank.quantity == 0)
                      {
                          // Save the full or empty wine tank
                          Console.WriteLine($"Saved {wineTank.quantity} from {wineTank.variety} WineTank.");
                      }
                      else
                      {
                          // Find the empty blending tank or partially filled blending tank with the same variety
                          BlendingTank targetBlendingTank = blendingTanks.FirstOrDefault(blendingTank =>
                              blendingTank.quantity == 0 || (blendingTank.quantity < blendingTank.capacity &&
                                                             blendingTank.variety == wineTank.variety));

                          if (targetBlendingTank != null)
                          {
                              int transferQuantity = Math.Min(wineTank.quantity, targetBlendingTank.capacity - targetBlendingTank.quantity);
                              targetBlendingTank.quantity += transferQuantity;
                              wineTank.quantity -= transferQuantity;
                              Console.WriteLine($"Transferred {transferQuantity} from {wineTank.variety} WineTank to BlendingTank.");
                          }
                          else
                          {
                              // Find the partially filled wine tank with the same variety
                              WineTank targetWineTank = wineTanks.FirstOrDefault(tank =>
                                  tank.quantity > 0 && tank.quantity < tank.capacity && tank.variety == wineTank.variety);

                              if (targetWineTank != null)
                              {
                                  int transferQuantity = Math.Min(wineTank.quantity, targetWineTank.capacity - targetWineTank.quantity);
                                  targetWineTank.quantity += transferQuantity;
                                  wineTank.quantity -= transferQuantity;
                                  Console.WriteLine($"Transferred {transferQuantity} from {wineTank.variety} WineTank to {targetWineTank.variety} WineTank.");
                              }
                              else
                              {
                                  Console.WriteLine($"No blending tank or wine tank available to save the wine from {wineTank.variety} WineTank.");
                              }
                          }
                      }
                  }

                  Console.WriteLine("Save process completed.");
                  // Display the contents of wine tanks and blending tanks
                  Console.WriteLine("Final contents of wine tanks:");
                  foreach (WineTank wineTank in wineTanks)
                  {
                      Console.WriteLine($"Variety: {wineTank.variety}, Quantity: {wineTank.quantity}");
                  }

                  Console.WriteLine("Final contents of blending tanks:");
                  foreach (BlendingTank blendingTank in blendingTanks)
                  {
                      Console.WriteLine($"Variety: {blendingTank.variety}, Quantity: {blendingTank.quantity}");
                  }

              }*/

        // New save method
        public static void Save()
        {
            Console.WriteLine("Save");
            var sortedWineTanks = wineTanks.OrderByDescending(tank => tank.quantity).ToList();
            var emptyBlendingTanks = blendingTanks.Where(blendingTank => blendingTank.quantity == 0).ToList();

            // Save the full or empty wine tanks
            foreach (WineTank wineTank in sortedWineTanks)
            {
                if (wineTank.quantity == wineTank.capacity || wineTank.quantity == 0)
                {
                    Console.WriteLine($"Saved {wineTank.quantity} from {wineTank.variety} WineTank.");
                }
            }

            // Transfer wine from partially filled wine tanks to blending tanks
            foreach (WineTank wineTank in sortedWineTanks)
            {
                if (wineTank.quantity > 0 && wineTank.quantity < wineTank.capacity)
                {
                    BlendingTank targetBlendingTank = emptyBlendingTanks.FirstOrDefault(blendingTank => blendingTank.variety == wineTank.variety);

                    if (targetBlendingTank != null)
                    {
                        int transferQuantity = Math.Min(wineTank.quantity, targetBlendingTank.capacity);
                        targetBlendingTank.quantity += transferQuantity;
                        wineTank.quantity -= transferQuantity;
                        Console.WriteLine($"Transferred {transferQuantity} from {wineTank.variety} WineTank to BlendingTank.");
                    }
                }
            }

            // Transfer wine from partially filled blending tanks to other blending tanks
            foreach (BlendingTank sourceBlendingTank in blendingTanks)
            {
                if (sourceBlendingTank.quantity > 0 && sourceBlendingTank.quantity < sourceBlendingTank.capacity)
                {
                    BlendingTank targetBlendingTank = blendingTanks.FirstOrDefault(blendingTank =>
                        blendingTank != sourceBlendingTank && blendingTank.variety == sourceBlendingTank.variety &&
                        blendingTank.quantity == 0);

                    if (targetBlendingTank != null)
                    {
                        int transferQuantity = Math.Min(sourceBlendingTank.quantity, targetBlendingTank.capacity);
                        targetBlendingTank.quantity += transferQuantity;
                        sourceBlendingTank.quantity -= transferQuantity;
                        Console.WriteLine($"Transferred {transferQuantity} from BlendingTank to BlendingTank.");
                    }
                }
            }

            Console.WriteLine("Save process completed.");
            // Display the contents of wine tanks and blending tanks
            Console.WriteLine("Final contents of wine tanks:");
            foreach (WineTank wineTank in wineTanks)
            {
                Console.WriteLine($"Variety: {wineTank.variety}, Quantity: {wineTank.quantity}");
            }

            Console.WriteLine("Final contents of blending tanks:");
            foreach (BlendingTank blendingTank in blendingTanks)
            {
                Console.WriteLine($"Variety: {blendingTank.variety}, Quantity: {blendingTank.quantity}");
            }
        }
    }
}





