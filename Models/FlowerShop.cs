using System;
using System.Collections.Generic;

namespace flowerShop
{

    public class FlowerShop
    {
        public List<Peony> PeonyList { get; set; } = new List<Peony>();
        public List<Lilac> LilacList { get; set; } = new List<Lilac>();
        public List<Protea> ProteaList { get; set; } = new List<Protea>();
        public List<Rose> RoseList { get; set; } = new List<Rose>();
        public List<Tulip> TulipList { get; set; } = new List<Tulip>();

        public List<IColorfulFlower> MakeMothersDayBouquet()
        {
            return new List<IColorfulFlower>{
                new Rose(){Color= "Pink", Price = 10.50},
                new Rose(){Color= "Yellow", Price = 10.50},
                new Tulip(){Color= "Yellow", Price = 10.50},
                new Peony(){Color= "Coral", Price = 10.50},
                new Lilac(){Color= "Lavender", Price = 10.50}
            };
        }
        public List<IStemFlower> MakeFathersDayBouquet()
        {
            return new List<IStemFlower>{
                new Rose(){StemLength= 5.5, Price = 10.50},
                new Rose(){StemLength= 29.2, Price = 10.50},
                new Protea(){StemLength= 30.2, Price = 10.50},
                new Protea(){StemLength= 19.2, Price = 10.50}
            };
        }

    }
}