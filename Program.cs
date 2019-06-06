using System;
using System.Collections.Generic;

namespace flowerShop
{
    class Program
    {
        static void Main(string[] args)
        {

            FlowerShop shop = new FlowerShop();
            List<IColorfulFlower> mothersBouquet = shop.MakeMothersDayBouquet();
            foreach (IColorfulFlower flower in mothersBouquet)
            {
                Console.WriteLine(flower);
            }
            // Rose aRose = new Rose()
            // {
            //     HasThorns = true,
            //     Color = "red",
            //     StemLength = 8.5,
            //     Price = 200.00
            // };

            // Lilac aLilac = new Lilac()
            // {
            //     HasThorns = false,
            //     Color = "lavender",
            //     Price = 70.00
            // };

            // Peony aPeony = new Peony()
            // {
            //     HasThorns = false,
            //     Color = "coral",
            //     Price = 400.00
            // };

            // Protea aProtea = new Protea()
            // {
            //     HasThorns = false,
            //     StemLength = 30.5,
            //     Price = 650.00
            // };

            // Tulip aTulip = new Tulip()
            // {
            //     HasThorns = false,
            //     Color = "Yellow",
            //     Price = 150.00
            // };
        }
    }
}
