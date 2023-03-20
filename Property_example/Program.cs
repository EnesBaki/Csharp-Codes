using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property_example
{
    class Program
    {
        static void Main(string[] args)
        {
            personel p1 = new personel();

            p1._tc = "12345678901";
            Console.WriteLine("tc no:" + p1._tc + "******");
            Console.ReadLine();
        }
    }
}
