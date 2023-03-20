using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase_ATM_
{
    class Program
    {
        static void Main(string[] args)
        {

            int bakiye = 1000;

            Console.WriteLine("1-Bakiye Görüntüle");
            Console.WriteLine("2-Para Çek");
            Console.WriteLine("3-Para Yatırma");
            Console.WriteLine("4-Çıkış Yap");
            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Tuşlayınız");

            int islem = Convert.ToInt32(Console.ReadLine());

            switch(islem)
            {
                case 1:
                    
                    Console.WriteLine("Güncel Tutar:" + bakiye);
                    Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine("Çekmek istediğiniz Tutarı giriniz");
                    int çektutar = Convert.ToInt32(Console.ReadLine());
                    if (çektutar > bakiye)
                    {
                        Console.WriteLine("Bakiyenizden fazla para çekemezsiniz.\n Tekrar deneyiniz...");
                        Console.ReadLine();
                    }

                    else
                    {
                        Console.WriteLine("Güncel Tutar:" + (bakiye - çektutar));
                        Console.ReadLine();
                    }

            
                    break;

                case 3:
                    Console.WriteLine("Yatırmak istediğiniz Tutarı giriniz");
                    int yattutar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Güncel Tutar:" + (bakiye + yattutar));
                    Console.ReadLine();
                    break;


                case 4:
                    Console.WriteLine("Çıkış Yapılıyor \n İyi Günler");
                    Console.ReadLine();
                    break;


                default:
                    Console.WriteLine("Lütfen geçerli bir değer giriniz");
                    Console.ReadLine();
                    break;





            }






        }
    }
}
