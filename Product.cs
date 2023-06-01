using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class Product
    {
        public Product(int id, string name, float price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public int id { get; set; }
        public string name { get; set; }
        public float price { get; set; }

    }
}
