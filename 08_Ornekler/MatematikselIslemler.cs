using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Ornekler
{
    internal class MatematikselIslemler
    {
        public double KdvFiyatHesapla(double aratoplam, int kdvOran)
        {
            return (aratoplam * kdvOran) / 100;
        }
    }
}
