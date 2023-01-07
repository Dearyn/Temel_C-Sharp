namespace _03Methotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program çalıştığı anda çalışan method");
            Console.ReadLine();


            EkranaYaz();
            Console.ReadLine();

            int toplamaSonuc = ToplamaYap(100, 50);
            Console.WriteLine(toplamaSonuc);

            double urunFiyat = 1000;
            int kdvOrani = 8;
            double kdvUcreti = KdvHesapla(urunFiyat, kdvOrani);
            double toplamFiyat = urunFiyat + kdvUcreti;
            Console.WriteLine("Ürün Fiyat: {0} Tl olan bir ürünün, KDV Oranı: %{1}'dir, Veri Ücreti: {2} TL, Toplam Ücret: {3} TL'dir ",urunFiyat,kdvOrani,kdvUcreti,toplamFiyat);

            /* Ref Keyword Mthod */
            int number3 = 40;
            int number4 = 100;
            int sonuc2 = OrnekTopla2(ref number3, number4);

            Console.WriteLine(sonuc2);
            Console.WriteLine(number3);
            Console.ReadLine();


            /* Out  Keyword Mthod */
            int number5;
            int number6 = 100;
            int sonuc3 = OrnekTopla3(out number5, number6);

            Console.WriteLine(sonuc3);
            Console.WriteLine(number5);
            Console.ReadLine();


            /* Params Keywoard */
            Console.WriteLine(ToplamaIslemitoplu(34,56,78,20,24,95,62));
            Console.ReadLine();

        }

        static void EkranaYaz()
        {
            Console.WriteLine("İlker ULAŞ");
        }
        static double KdvHesapla(double fiyat, int kdvOran)
        {
            return (fiyat * kdvOran)/100 ;
        }
        static int ToplamaYap(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        /* Örnek 1 Standart Method*/

        static int OrnekTopla1(int number1, int number2)
        {
            number1 = 50;
            int sonuc = number1 + number2;
            return sonuc;
        }

        /* Ref Keywor Method*/

        static int OrnekTopla2(ref int number3, int number4)
        {
            number3 = 50;
            int sonuc = number3 + number4;
            return sonuc;
        }

        /* Out Keywoard Standart Method*/

        static int OrnekTopla3(out int number5, int number6)
        {
            number5 = 60;
            int sonuc = number5 + number6;
            return sonuc;
        }

        /* Method Overloading */

        static int OrnekTopla3(int number1, int number2, int number3)
        {
            number1 = 60;
            int sonuc = number1 + number2 + number3;
            return sonuc;
        }

        /* Params Keywoard */

        static int  ToplamaIslemitoplu(params int[] sayilar)
        {
            return sayilar.Sum();
        }
    } 
}