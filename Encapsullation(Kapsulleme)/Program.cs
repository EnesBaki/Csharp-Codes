using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsullatıon_kapsülleme_
{
    class Program
    {
        static void Main(string[] args)
        {
            kitaplar book1 = new kitaplar();

            book1.set("intibah");
            Console.WriteLine(book1.get());
            Console.ReadLine();
        }
    }
}
