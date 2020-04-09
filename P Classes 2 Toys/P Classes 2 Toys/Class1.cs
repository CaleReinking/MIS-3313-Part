using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P_Classes_2_Toys
{
    class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        private string Aisle { get; set; }
        public Toy()
        {
            Manufacturer = "";
            Name = "";
            Price = 0;
            Aisle = "";

        }
        public string GetAisle()
        {
            return Manufacturer.First().ToString().ToUpper();
        }
        public string GetAisle2()
        {
            Random rand = new Random();
            int randomnumber = rand.Next(1, 24);
            return randomnumber.ToString();
        }
    }
}
