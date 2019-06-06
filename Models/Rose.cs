using System;

namespace flowerShop
{

    public class Rose : IStemFlower, IColorfulFlower
    {
        public string Color { get; set; }
        public double Price { get; set; }
        public bool HasThorns { get; set; }

        public double StemLength { get; set; }
        public override string ToString()
        {
            return $"A {Color} rose is {Price:c}.";
        }

    }
}