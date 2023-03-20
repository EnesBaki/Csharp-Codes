using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖRNEK_login
{
    class Program
    {
        static void Main(string[] args)
        {


            string user = "cimbom";
            string password = "0123";
            int a = 1;
            while (true)
            { 
            Console.WriteLine("Lütfen kullanici adinizi giriniz");
            string girdiuser = Console.ReadLine();
            Console.WriteLine("Lütfen şifrenizi giriniz");
            string girdipassword = Console.ReadLine();

                if (girdipassword == password && girdiuser == user)
                {
                    Console.WriteLine("Başarıyla giriş yaptınız");
                    Console.ReadLine();
                    break;
                }

                else {
                    
                    Console.WriteLine(a + "defa hatalı giriş yaptınız. 3 hatalı girişte bloke olur");
                    a++; 

                       if(a==4)
                    { Console.WriteLine("3 Hatalı giriş yaptınız sistem bloke oldu");
                      Console.ReadLine();
                       break;
                    }

                       

                }

            }

        }
    }
}
