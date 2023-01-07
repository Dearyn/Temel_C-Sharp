namespace _13StaticClassVeMethodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Islemler islemler = new Islemler();
            islemler.EkranaYaz();

            ClassimNewlenmez.sayi = 5;
            ClassimNewlenmez.sayi = 8;

            Islemler.EkranaYazStatic();
            Console.WriteLine(ClassimNewlenmez.sayi);
            Console.ReadLine();

            string cumle = "Merhaba arkadaşlar burada static olarak tanımlanmış AletCantam Classı içerisindeki static classlar ile işlem yapıyoruz";

            string yeniCumle=AletCantam.BuyukHarfCevir(cumle);
            yeniCumle=AletCantam.TurkceKarakterleriYokEt(yeniCumle);

            Console.WriteLine(yeniCumle);

            Console.ReadLine();
        }
    }

    static class ClassimNewlenmez
    {
        public static int sayi { get; set; }
    }

    class Islemler
    {
        public void EkranaYaz()
        {
            Console.WriteLine("Merhaba Yazdım!");
        }

        public static void EkranaYazStatic()
        {
            Console.WriteLine("Merhaba Yazdım Static!");
        }
    }

    static class StaticClassim
    {
        static StaticClassim()
        {

        }
    }
}