using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Araba car1 = new Araba();

            car1.ArabaModel = "Renault";
            car1.ArabaRenk = "Siyah";
            car1.KapiSayisi = 5;
            car1.KapıKilitle();
            car1.MotorÇaıştır();


            Console.WriteLine("Araba rengi:" + car1.ArabaRenk);
            Console.WriteLine("Araba modeli:" + car1.ArabaModel);
            Console.ReadLine();


        }
    }
}
