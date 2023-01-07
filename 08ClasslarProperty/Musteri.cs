using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08ClasslarProperty
{
    internal class Musteri
    {
        public int Id { get; set; } // prop yazıp 2 kez taba basarsak müşterinin özelliklerini kullanmak için kullandığımız nesen oluşrur.

        private string _adi;

        public string Ad
        {
            get { return "Hoşgeldiniz: " + _adi; } // Değeri okurken başına Hoşgeldin ekletiyoruz.
            set { _adi = value; } // 
        }

        public string Soyad;

        public string Sehir { get; set; }
    }
}
