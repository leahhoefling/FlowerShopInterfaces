using System;

namespace flowerShop
{

    public class Protea : IStemFlower
    {
        public double Price { get; set; }
        public bool HasThorns { get; set; }

        public double StemLength { get; set; }
        public override string ToString()
        {
            return $"A Protea is {Price:c}.";
        }

    }
}