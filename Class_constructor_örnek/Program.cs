using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_constructor_örnek
{
    class Program
    {
        static void Main(string[] args)
        {
            phone tel1 = new phone("Enes","Apple","Siyah",2018,6000);
            phone tel2 = new phone("Yakup", "Xiaomi", "Blue", 2020, 5000);
            phone tel3 = new phone("Kayra", "LG", "Gri", 201, 5000);

            tel1.info();
            tel2.info();
            tel3.info();
            Console.ReadLine();
            
            
        }
    }
}
