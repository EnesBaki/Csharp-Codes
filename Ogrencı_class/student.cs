using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace öğrenci_Class
{
    class student
    {
        private int no;
        private string isim;
        private string soyisim;
        private string okulisim;
        private double vize1;
        private double vize2;
        private double final;
        private double ortalama;

        public student(int in_no,string in_isim,string in_soyisim,string in_okulisim,double in_vize1,double in_vize2,double in_final)

        {
            no = in_no;
            isim = in_isim;
            soyisim = in_soyisim;
            okulisim = in_okulisim;
            vize1 = in_vize1;
            vize2 = in_vize2;
            final = in_final;
            


        }


        public void Bilgi()
        {
            Console.WriteLine(isim + " " + soyisim + " Adlı Öğrencinin Bilgileri \n");
            Console.WriteLine("Numara:" + no);
            Console.WriteLine("Okul:" + okulisim);
            
        }

        public void OrtHesapla()
        { ortalama = vize1 * 0.3 + vize2 * 0.3 + final * 0.4;
            Console.WriteLine("Ortalama:" + ortalama);
        }

        
    }
}
