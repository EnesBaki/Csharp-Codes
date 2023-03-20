using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_constructor_örnek
{
    class phone
    {
        public string owner;
        public string brand;
        public string color;
        public int year;
        public int price;

        public phone(string in_owner, string in_brand, string in_color, int in_year,int in_price)
        {
            owner = in_owner;
            brand = in_brand;
            color = in_color;
            year = in_year;
            price = in_price;
               
        }

        public void info()
        {
            Console.WriteLine(year + " model " + color + " renkli " + brand + " telefonunun sahibi:" + owner);
        }
        


    }
}
