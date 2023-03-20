using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_Döngü
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 1;
            int b = 100;
            while(a<10)
            { Console.WriteLine(a);
                a++;

            }


            while(b>=0)
            { Console.Write(b + ", ");
                b -= 2;
            }

           

            //do while
            int x = 1;
            do
            {
                Console.WriteLine(x);
                x++;


            } while (x <= 10);
            Console.ReadLine();
        }



    }
}
