using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_kalıpalr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen sırasıyla 3 notunuzu giriniz");
            string not1 = Console.ReadLine();
            string not2 = Console.ReadLine();
            string not3 = Console.ReadLine();

            int n1 = Convert.ToInt32(not1);
            int n2 = Convert.ToInt32(not2);
            int n3 = Convert.ToInt32(not3);

            int ortalama = (n1 + n2 + n3) / 3;

            if (ortalama < 50)
                { Console.WriteLine("Başarısız"); 
                }

            else if (50<ortalama && ortalama<80)
            {
                Console.WriteLine("İYİ");
             
                    }


            else
            {
                Console.WriteLine("Çok İyi");
                
            }
            Console.ReadLine();
        }


    }
}
