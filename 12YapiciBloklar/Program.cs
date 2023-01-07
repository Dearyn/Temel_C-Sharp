namespace _12YapiciBloklar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MusteriIslemleri musteriIslemleri = new MusteriIslemleri();

            musteriIslemleri.Kaydet();

            Console.ReadLine();

            MusteriIslemleriTekrarla musteriIslemleriTekrarla = new MusteriIslemleriTekrarla(5);
            musteriIslemleriTekrarla.Tekrarla();
            musteriIslemleriTekrarla.EkranaYazdir();

            Console.ReadLine();
        }

        class MusteriIslemleri
        {
            public MusteriIslemleri()
            {
                Console.WriteLine("Default Olarak Çalıştı");
            }

            public void Kaydet()
            {
                Console.WriteLine("Kaydetme İşlem Yapıldı");
            }

            public void Sil()
            {
                Console.WriteLine("Silme İşlemi Yapıldı");
            }
        }

        class MusteriIslemleriTekrarla
        {
            private int _sayi = 10;

            public MusteriIslemleriTekrarla(int sayi)
            {
                _sayi = sayi;
            }

            public MusteriIslemleriTekrarla()
            {
            }

            public void Tekrarla()
            {
                Console.WriteLine("Yapı bloğu(Constructor) methoduyla newlendiği anda gönderilen sayi: {0}  Newlenmesinden sonra oluşaturulacak tüm işlemlerde bu sayı kullanılır." ,_sayi);
            }

            public void EkranaYazdir()
            {
                for (int i = 1; i <= _sayi; i++)
                {
                    Console.WriteLine("{0}-Merhaba", i);
                }
            }
        }
    }
}