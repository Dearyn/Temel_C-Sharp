using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13StaticClassVeMethodlar
{
    static class AletCantam
    {
        public static string BuyukHarfCevir(string gelenDeger)
        {
            return gelenDeger.ToUpper();
        }

        public static string TurkceKarakterleriYokEt(string gelenDeger)
        {
            gelenDeger = gelenDeger.Replace("ü", "u");
            gelenDeger = gelenDeger.Replace("Ü", "U");
            gelenDeger = gelenDeger.Replace("ç", "c");
            gelenDeger = gelenDeger.Replace("Ç", "C");
            gelenDeger = gelenDeger.Replace("ö", "o");
            gelenDeger = gelenDeger.Replace("Ö", "O");
            gelenDeger = gelenDeger.Replace("ş", "s");
            gelenDeger = gelenDeger.Replace("Ş", "S");
            gelenDeger = gelenDeger.Replace("ı", "i");
            gelenDeger = gelenDeger.Replace("İ", "I");
            gelenDeger = gelenDeger.Replace("ğ", "g");
            gelenDeger = gelenDeger.Replace("Ğ", "G");

            return gelenDeger;
        }
    }
}
