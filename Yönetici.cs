using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel_Yönetim_Sistemi
{
    internal class Yönetici:Personel
    {
        private int yönetilenkisi;

        //Yöneticinin yapıcı metodu
        public Yönetici(string ad,string soyad,decimal maas, int yönetilenkisi)
            :base(ad,soyad,maas)
        {
            this.yönetilenkisi=yönetilenkisi ;
        }

        //Getter ve Setter Metodu
        public int YonetilenKisi
        {
            get { return yönetilenkisi; }
            set
            {
                if (value > 0)
                    YonetilenKisi = value;
                else
                    Console.WriteLine("Yönetilen kişi sayısı sıfırdır");
            }
        }
        public void BilgiGoster()
        {
            base.BilgiGoster();
            Console.WriteLine("Yönetilen Kişi Sayısı:"+yönetilenkisi);
        }
    }
}
