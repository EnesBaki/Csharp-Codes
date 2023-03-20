using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tür_Dönüşümü
{
    class Program
    {
        static void Main(string[] args)
        {  
            
            // STRING->INT
            String sayi1 =" 1";
            String sayi2 = "2";
            Console.WriteLine( sayi1 + sayi2);

            int number1 = int.Parse(sayi1);

            

            /* BAŞKA YOL */
            int number2 = Convert.ToInt32(sayi2);
          

            Console.WriteLine(number1.GetType());
            Console.WriteLine(sayi1.GetType());

            Console.ReadLine();

            //INT -> STRING 

            int k = 5;

            string x = k.ToString();
            Console.WriteLine(x);

            // ToString();
            // ToDouble();
            // Convert.ToInt();
            // int.parse();
            //(int)


        }
    }
}
