using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreach_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] age = new int[5];
            
            for(int i=0;i<5;i++)
            {
                Console.WriteLine(i + ". index değerini giriniz");
                age[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int eleman in age)
            {
                Console.WriteLine(eleman);

            } Console.ReadLine();
        }
    }
}
