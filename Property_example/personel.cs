using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property_example
{
    class personel
    {
        private string tc;

        public string _tc
        {
            set
            {
                bool kontrol = false;

                if (value.Length == 11)
                {
                    for (int a = 0;a< value.Length; a++)
                        {
                        bool sayimi =char.IsNumber(value[a]);
                        
                        if(sayimi)
                        { }

                        else
                        {
                            kontrol = true;
                            break;
                        }

                    }

                    if(kontrol)
                    { Console.WriteLine("TC DE geçersiz karakter bulundu"); }

                    else
                    { tc = value; }
                }

                else
                { Console.WriteLine("tc 11 karakter değil"); }



            }


            get
            {
                return tc.Substring(0, 5);

            }

        }
    }
}
