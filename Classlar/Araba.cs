using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlar
{
    class Araba
    {
        public string ArabaModel;
        public int KapiSayisi;
        public string ArabaRenk; 

        public void MotorÇaıştır()
        { Console.WriteLine("Motor Çalışıyor"); }
        
        public void KapıKilitle()
        { Console.WriteLine("Kapılar Kilitlendi"); }
    }
}
