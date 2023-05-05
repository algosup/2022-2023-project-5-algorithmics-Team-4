using System;
using System.Collections.Generic;

namespace KrugChampagne
{
    class Program
    {

        static void Main(string[] args)
        {

            var tanks = new List<Tank>
            {
                new Tank("Tank1", 10),
                new Tank("Tank2", 20),
                new Tank("Tank3", 5),
                new Tank("Tank4", 15),
                new Tank("Tank5", 30),

            };

            var wines = new List<Wine>
            {
                new Wine("Classic", 1),
                new Wine("Mathusalem", 6),
                new Wine("Jéroboam", 3),
                new Wine("Melchisédech", 30),
                new Wine("Magnum", 1.5),

            };


            foreach (Tank tank in tanks)
            {
                Console.WriteLine(tank.ToString());
            }

            foreach (Wine wine in wines)
            {
                
                Console.WriteLine(wine.ToString());
            }

            var scndWine = wines[1];
            var firstTank = tanks[2];
            firstTank.Fill(scndWine.GetVolume()); // volume wine > capacity tank thus there's exception

            foreach (Tank tank in tanks)
            {
                Console.WriteLine(tank.ToString());
            }

            Console.ReadLine();
            
        }
    }
}