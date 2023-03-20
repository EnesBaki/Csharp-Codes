using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Döngü
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faktoriyel Hesaplama Programı

            Console.WriteLine("Faktoriyel Hesaplanacak Sayıyıyı Giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sonuc = 1;
            for (int a=2;a<=sayi;a++)
            {   
                sonuc = sonuc* a;
                
                if (sayi == a)
                
                {
                    Console.Write("Sonuç:");
                    Console.Write(sonuc); }
            }

            //iç içe for döngüsü

            for (int i = 1; i <= 10; i++)
            { for (int j = 1; j <= i; j++)
                    Console.Write(j);
                Console.WriteLine("");
                    }

            Console.ReadLine();
            
        }
    }
}
