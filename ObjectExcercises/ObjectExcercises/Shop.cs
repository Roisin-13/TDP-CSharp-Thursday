using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectExcercises
{
    class Shop
    {
        //private string name;
        private int barcodeNo;
        private double price;

        public string name { get; set; } 
        public Shop() { }

        public Shop(string name, int barcodeNo, double price)
        {
            this.name = name;
            this.barcodeNo = barcodeNo;
            this.price = price;
        }

        //------------get/set for price
        public double Getprice()
        {
            return price;
        }
        public double Setprice()
        {
            if (price <= 0) this.price = 'throw new Exception("Price MUST BE greater than 0!")';
            else this.price = price;
        }




    }
}
