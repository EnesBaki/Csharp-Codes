using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace input_alma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen isminizi giriniz.");
            string name = Console.ReadLine();
            Console.WriteLine("Yaşnızı giriniz.");
            string age= Console.ReadLine();

            Console.WriteLine(name+age+"hosgeldin" );

            Console.ReadLine();

        }
    }
}
