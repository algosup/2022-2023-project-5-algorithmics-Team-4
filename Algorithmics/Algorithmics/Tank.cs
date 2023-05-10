using System;

namespace KrugChampagne
{
    public class Tank
    {
        private static int _nextId = 1;

        public int Id { get; }
        public string Name { get; }
        public int Capacity { get; }
        public double CurrentVolume { get; private set; }

        public Tank(string name, int capacity)
        {
            Id = _nextId++;
            Name = name;
            Capacity = capacity;
            CurrentVolume = 0;
        }

        public void Fill(double volume)
        {
            if (CurrentVolume + volume > Capacity)
            {
                throw new ArgumentException("Cannot fill tank beyond capacity.");
            }

            CurrentVolume += volume;
        }

        public void Empty()
        {
            CurrentVolume = 0;
        }

        public override string ToString()
        {
            return $"Tank ID : {Id} \nTank Name : {Name} \nTank Capacity : {Capacity} \nTank Current Volume : {CurrentVolume} \n";
        }
    }
}

