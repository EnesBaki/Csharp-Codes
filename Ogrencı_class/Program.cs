using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace öğrenci_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            student öğrenci1 = new student(001, "EnesBaki", "Bedir", "BTÜ", 80, 90, 100);

            öğrenci1.Bilgi();
            öğrenci1.OrtHesapla();
            Console.ReadLine();
        }
    }
}
