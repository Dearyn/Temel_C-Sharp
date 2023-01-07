namespace _14Koleksiyonlar
{
    using System.Collections;
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayListKullanim();

            //TipBelirliListKullanimi();

            MusteriDegerleri musteriBilgisi = new MusteriDegerleri();
            musteriBilgisi.Id = 1;
            musteriBilgisi.AdiSoyadi = "İlker ULAŞ";

            MusteriDegerleri musteri = new MusteriDegerleri { Id = 2, AdiSoyadi = "İlker ULAŞ" };

            List<MusteriDegerleri> musteriler = new List<MusteriDegerleri>();
            musteriler.Add(musteriBilgisi);
            musteriler.Add(musteri);
            musteriler.Add(new MusteriDegerleri { Id = 3, AdiSoyadi = "İlker ULAŞ" });
            musteriler.Add(new MusteriDegerleri { Id = 4, AdiSoyadi = "İlknur ULAŞ" });

            List<MusteriDegerleri> musteriler2 = new List<MusteriDegerleri>
            {
                new MusteriDegerleri { Id = 5,AdiSoyadi="Hasan Hüseyin ULAŞ" },
                new MusteriDegerleri { Id = 6,AdiSoyadi="Zeynep ULAŞ" },
                new MusteriDegerleri { Id = 7,AdiSoyadi="Firdevs ULAŞ" },
                new MusteriDegerleri { Id = 8,AdiSoyadi="Mustafa ULAŞ" },
            };

            foreach (MusteriDegerleri m in musteriler)
            {
                Console.WriteLine("Müşteri Id: {0}, Adı ve Soyadı: {1}", m.Id, m.AdiSoyadi);
            }

            foreach (MusteriDegerleri m in musteriler2)
            {
                Console.WriteLine("Müşteri Id: {0}, Adı ve Soyadı: {1}", m.Id, m.AdiSoyadi);
            }

            Console.ReadLine();


        }

        private static void TipBelirliListKullanimi()
        {
            List<string> sehirİsimleri = new List<string>();
            sehirİsimleri.Add("Tekirdağ");
            sehirİsimleri.Add("İstanbul");
            sehirİsimleri.Add("Ankara");
            sehirİsimleri.Add("İzmir");

            foreach (string sehir in sehirİsimleri)
            {
                Console.WriteLine(sehir);
            }
            Console.ReadLine();
        }

        private static void ArrayListKullanim()
        {
            ArrayList Sehirler = new ArrayList();
            Sehirler.Add("Ankara");
            Sehirler.Add("İstanbul");
            Sehirler.Add("Tekirdağ");

            foreach (string sehir in Sehirler)
            {
                Console.WriteLine(sehir);
            }

            Sehirler.Add(5);
            Console.WriteLine(Sehirler[3]);
            Console.ReadLine();
        }
    }

    class MusteriDegerleri
    {
        public int Id { get; set; }

        public string AdiSoyadi { get; set; }
    }
}