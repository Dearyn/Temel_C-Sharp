namespace _07Classlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ALetCantam aletCantam=new ALetCantam();

            string cumle = "Merhaba bugün hava çoğğğ güzel...";
            string yeniCumle=aletCantam.BuyukHarfCevir(cumle);
            yeniCumle=aletCantam.TurkceKarakterleriYokEt(yeniCumle);

            Console.WriteLine(yeniCumle);
            Console.WriteLine("#####################");


            MusteriIslemleri musteriIslemleri=new MusteriIslemleri();

            musteriIslemleri.VeritabaninaEkle();
            Console.WriteLine("#####################");

            int sonuc = musteriIslemleri.Toplama(10, 63);
            Console.WriteLine(sonuc);
            Console.WriteLine("#####################");

            Console.Write("Değer 1 Giriniz: ");
            string deger1=Console.ReadLine();
            Console.Write("Değer 2 Giriniz: ");
            string deger2 = Console.ReadLine();
            Console.Write("SONUÇ: {0}",musteriIslemleri.Toplama(Convert.ToInt32(deger1), Convert.ToInt32(deger2)));

            Console.ReadLine();
        }
    }

    class ALetCantam
    {
        public string BuyukHarfCevir(string gelenDeger)
        {
            return gelenDeger.ToUpper();
        }

        public string TurkceKarakterleriYokEt(string gelenDeger)
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

    class MusteriIslemleri
    {
        public int Toplama(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public void VeritabaninaEkle()
        {
            Console.WriteLine("Veritabanına veriler eklendi");
        }
    }
}