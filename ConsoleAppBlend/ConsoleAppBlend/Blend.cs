using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBlend
{
    internal class Blend
    {
    }
   
    public class BlendTanker
    {
        public int capacity;
        public int quantity;
        public int remaining;
        public double ratio;
    }

    public class MainTanker
    {
        public int capacity;
        public int quantity;
      
    }
  

class Blender
{
     public static void Blending ()
    {
        IEnumerable<BlendTanker> blendTankers = new List<BlendTanker>
        {
           // new BlendTanker { capacity = 400, quantity = 400, remaining = 0, ratio = 0.7 },
            //new BlendTanker { capacity = 150, quantity = 150, remaining = 0, ratio = 0.15 },
            //new BlendTanker { capacity = 100, quantity = 100, remaining = 0, ratio = 0.15 },

            new BlendTanker { capacity = 100, quantity = 100, remaining = 0, ratio = 0.25 },
            new BlendTanker { capacity = 200, quantity = 200, remaining = 0, ratio = 0.25 },
            new BlendTanker { capacity = 300, quantity = 300, remaining = 0, ratio = 0.25 },
            new BlendTanker { capacity = 400, quantity = 400, remaining = 0, ratio = 0.25 },
            

        };
            double totalRatio = blendTankers.Sum(x => x.ratio);
            int totalCapacity = blendTankers.Sum(x => x.capacity);
            int totalQuantity = blendTankers.Sum(x => x.quantity);
            int totalRemaining = blendTankers.Sum(x => x.remaining);
            double totalRatioCheck = blendTankers.Sum(x => x.ratio);
            Console.WriteLine("Total Ratio: " + totalRatio);
            Console.WriteLine("Total Capacity: " + totalCapacity);
            Console.WriteLine("Total Quantity: " + totalQuantity);
            Console.WriteLine("Total Remaining: " + totalRemaining);
            Console.WriteLine("Total Ratio Check: " + totalRatioCheck);

            //int mainTankerCapacity = 400;
            int mainTankerCapacity = 400;
            int mainTankerQuantity = 0;
            double mainTankerQuantityDouble = 0.0;
            double mainTankerCapacityDouble = 0.0;
            double blendTankerCapacityDouble = 0.0;
            int trig=0; // for debug
            bool flag = false; 

            MainTanker mainTanker = new MainTanker();
            mainTanker.capacity = mainTankerCapacity;
            mainTanker.quantity = mainTankerQuantity;
            bool itIsOver = false;

            Console.WriteLine("Main Tanker Capacity: " + mainTanker.capacity);
            Console.WriteLine("Main Tanker Quantity: " + mainTanker.quantity);
            Console.WriteLine("It's Over ? => "+itIsOver);
            Console.WriteLine("////////////////////////////");
           

            // 1. Check if the total ratio is 100%
            // 2. Check if the blendTanker capacity is greater than the mainTanker capacity * ratio
            // 3. If it's true, then transfer the quantity from the blendTanker to the mainTanker   
            while (mainTanker.quantity < mainTanker.capacity && !flag)
            {
                foreach (BlendTanker blendTanker in blendTankers)
                {
                  if (totalRatio == 1)
                    {
                        if (Convert.ToDouble(blendTanker.capacity) >= Convert.ToDouble(mainTanker.capacity) * blendTanker.ratio   )
                            
                        {
                            trig++;
                           
                            Console.WriteLine("loop iteration" + trig);
                            Console.WriteLine("blendTankerCapacity: " + blendTanker.capacity + " Main ratio quantity: " + Convert.ToDouble(mainTanker.capacity) * blendTanker.ratio);
                            Console.WriteLine("Main Tanker Capacity" + mainTanker.capacity);
                            Console.WriteLine("Main Tanker Quantity" + mainTanker.quantity);
                            
                            blendTankerCapacityDouble = Convert.ToDouble(blendTanker.capacity);
                            mainTankerCapacityDouble = Convert.ToDouble(mainTanker.capacity);
                            Console.WriteLine("Main Tanker Capacity Double: " + mainTankerCapacityDouble);
                          mainTankerQuantityDouble = mainTankerCapacityDouble * blendTanker.ratio;
                            mainTanker.quantity += Convert.ToInt32(mainTankerQuantityDouble);
                            
                            Console.WriteLine("Main Tanker Quantity Double: " + mainTankerQuantityDouble);
                            Console.WriteLine("No Int? megamind meme " + Convert.ToInt32(mainTankerQuantityDouble));
                            Console.WriteLine("Main Tanker Quantity: " + mainTanker.quantity);
                            
                            blendTanker.quantity -= Convert.ToInt32(mainTankerQuantityDouble);
                            Console.WriteLine("Blend Tanker Capacity: " + blendTanker.capacity);
                            Console.WriteLine("Blend Tanker Quantity: " + blendTanker.quantity);



                        }
                        else
                        {

                            Console.WriteLine("Blend Tanker don't have enought space for the transfert: Transfert cancel...");
                            itIsOver = true;
                            flag = true;
                            break;
                           
                        }


                    }
                    else
                    {
                        Console.WriteLine("It's expected to have 100% total ratio: Transfert cancel...");
                        itIsOver = true;
                        flag = true;
                        break;
                        
                    } 
                    
                }
               

            }

            Console.WriteLine("////////////////////////////");

            Console.WriteLine("Main Tanker Capacity: " + mainTanker.capacity);
            Console.WriteLine("////////////////////////////");

            trig = 0;
          if (itIsOver == false )
            {
                foreach (BlendTanker blendTanker in blendTankers)
                {
                    if (blendTanker.quantity == 0)
                    {
                        trig++;

                        Console.WriteLine("Blend Tanker " + trig + " is empty");
                    }
                    else if (blendTanker.quantity == blendTanker.capacity)
                    {
                        trig++;
                        Console.WriteLine("Blend Tanker " + trig + " is full");
                    }
                    else
                    {
                        trig++;
                        Console.WriteLine("Blend Tanker " + trig + " is not full or empty");

                        blendTanker.remaining = blendTanker.capacity - blendTanker.quantity;
                        totalRemaining += blendTanker.remaining;
                        Console.WriteLine("Blend Tanker " + trig + " remaining: " + blendTanker.remaining);


                    }

                }

            }
           

            Console.WriteLine("////////////////////////////");
            Console.WriteLine("total remaining" + totalRemaining);
            Console.WriteLine("////////////////////////////");
            flag = false;
            trig= 0;
            int? previousTanker = null;
            List<int>  findBiggestTanker = new List<int>();
            List<int> indexOfTanker = new List<int>();
            if(itIsOver == false)
            {
                foreach (BlendTanker blendTanker in blendTankers)
                {
                    indexOfTanker.Add(blendTanker.quantity);
                    if (blendTanker.capacity == blendTanker.quantity)
                    {
                        trig++;
                        Console.WriteLine("ignore tanker N°" + trig + ", he is full");
                    }
                    else
                    {
                        trig++;
                        findBiggestTanker.Add(blendTanker.capacity);
                        Console.WriteLine("Tanker N° " + trig + " is not full");
                    }





                }

            }
            int biggest =0;
           if(itIsOver == false)
            {
               biggest =+ findBiggestTanker.Max();
            }
            
            trig = 0;
           
            if (itIsOver == false)
            {
                if (totalRemaining == 0)
                {
                    Console.WriteLine("All Tankers are Empty or Full. Operation is over!");
                    flag = true;
                }
                else
                {
                    Console.WriteLine("There is still some leftover. We need to transfer it to the blend tankers!");

                    // Sort the blend tankers based on their remaining capacity in descending order
                    var sortedTankers = blendTankers.OrderByDescending(tanker => tanker.remaining);

                    foreach (BlendTanker blendTanker in sortedTankers)
                    {
                        Console.WriteLine("blendTanker capacity: " + blendTanker.capacity + ", biggest: " + biggest);

                        if (totalRemaining >= blendTanker.capacity)
                        {
                            trig++;
                            Console.WriteLine("Tanker N° " + trig + " can be filled");

                            if (blendTanker.capacity == biggest && blendTanker.capacity > blendTanker.quantity)
                            {
                                Console.WriteLine("Tanker N°" + trig + " is the biggest and expected to be filled first!");

                                int remainingToFill = blendTanker.capacity - blendTanker.quantity;
                                if (remainingToFill <= totalRemaining)
                                {
                                    blendTanker.quantity += remainingToFill;
                                    blendTanker.remaining = 0;
                                    totalRemaining -= remainingToFill;
                                }
                                else
                                {
                                    blendTanker.quantity += totalRemaining;
                                    blendTanker.remaining = blendTanker.capacity - blendTanker.quantity;
                                    totalRemaining = 0;
                                }
                            }
                            else if (blendTanker.capacity != biggest && blendTanker.capacity > blendTanker.quantity)
                            {
                                Console.WriteLine("Tanker N°" + trig + " is not the biggest. It is expected to be filled after the biggest if possible!");

                                int remainingToFill = blendTanker.capacity - blendTanker.quantity;
                                if (remainingToFill <= totalRemaining)
                                {
                                    blendTanker.quantity += remainingToFill;
                                    blendTanker.remaining = 0;
                                    totalRemaining -= remainingToFill;
                                }
                                else
                                {
                                    blendTanker.quantity += totalRemaining;
                                    blendTanker.remaining = blendTanker.capacity - blendTanker.quantity;
                                    totalRemaining = 0;
                                }
                            }
                        }
                        else
                        {
                            trig++;
                            Console.WriteLine("Tanker N° " + trig + " can't be filled");
                        }
                    }
                }
            }
            Console.WriteLine("////////////////////////////");

            Console.WriteLine("////////////////////////////");
            Console.WriteLine("total remaining" + totalRemaining);
            foreach (BlendTanker blendTanker in blendTankers)
            {
                Console.WriteLine("blendTanker capacity: " + blendTanker.capacity + ", quantity: " + blendTanker.quantity + ", remaining: " + blendTanker.remaining);
            }
            Console.WriteLine("////////////////////////////");
          



          
          
           
           
           
          


            




       

        
    }
}

}
