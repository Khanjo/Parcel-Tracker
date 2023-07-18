using System.Collections.Generic;

namespace Parcels.Models
{
    public class Parcel
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        private static List<Parcel> _instances = new List<Parcel> { };
        public Parcel(int length, int width, int height, int weight)
        {
            Length = length;
            Width = width;
            Height = height;
            Weight = weight;
            _instances.Add(this);
        }
        public int Volume(int width, int length, int height)
        {
            int volume = width * length * height;
            return volume;
        }
        public int CostToShip(int volume, int weight)
        {
            int cost = volume * weight / 200;
            return cost;
        }
        public static List<Parcel> GetAll()
        {
            return _instances;
        }
    }
}