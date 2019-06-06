using System;

namespace flowerShop
{

    public class Lilac : IColorfulFlower
    {
        public string Color { get; set; }
        public double Price { get; set; }
        public bool HasThorns { get; set; }

        public override string ToString()
        {
            return $"A {Color} lilac is {Price:c}.";
        }

    }
}