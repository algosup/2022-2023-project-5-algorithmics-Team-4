using System;

namespace KrugChampagne
{
    public class Wine
    {
        private static int _nextId = 1;

        public int Id { get; }
        public string Name { get; set; }
        public double Volume { get; set; }
        public decimal Price { get; set; }

        public Wine(string name, double volume)
        {
            Id = _nextId++;
            Name = name;
            Volume = volume;
        }

        public override string ToString()
        {
            return $"Wine ID : {Id} \nWine Name : {Name} \nWine Volume : {Volume} \n ";
        }

        public double GetVolume()
        {
            return Volume;
        }
    }
}

