using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel_Yönetim_Sistemi
{
    internal class Personel
    {
        //Kapsülleme için private özellikleri tanımlayalım
        private string ad;
        private string soyad;
        private decimal maas;

        //Constructor
        public Personel(string ad,string soyad, decimal maas)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.maas = maas;
        }

        //Getter ve Setter ile erişimleri sağlayalım
        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }
        public decimal Maas
        {
            get { return maas; }

            set
            {
                if (value > 0)
                {
                    maas = value;
                }
                else
                {
                    Console.WriteLine("Maaş 0'dan büyük olmalıdır");
                }
            }
        }
            //Ortak Özellik
            public void BilgiGoster()
            {
              Console.WriteLine("Ad:"+ad);
              Console.WriteLine("Soyad:"+soyad);
              Console.WriteLine("Maaş:"+maas);


            }
   


        }
    }

