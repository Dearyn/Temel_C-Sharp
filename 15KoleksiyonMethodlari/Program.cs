namespace _15KoleksiyonMethodlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<MusteriDegerleri> musteriler = new List<MusteriDegerleri>
            {
                new MusteriDegerleri { Id = 1,Adi="Erci" },
                new MusteriDegerleri { Id = 2,Adi="Samet" },
                new MusteriDegerleri { Id = 3,Adi="İlker" },
                new MusteriDegerleri { Id = 4,Adi="Özkan" },
                new MusteriDegerleri { Id = 5,Adi="Mehmet" },
                new MusteriDegerleri { Id = 6,Adi="Alperen" },
            };

            MusteriDegerleri musteriDegerleri1 = new MusteriDegerleri
            {
                Id = 7,
                Adi = "Ege"
            };

            musteriler.Add(musteriDegerleri1);
            musteriler.Add(new MusteriDegerleri { Id = 8, Adi = "Özge" });

            musteriler.AddRange(
                new MusteriDegerleri[2]
                {
                    new MusteriDegerleri{Id = 9, Adi = "Ali"},
                    new MusteriDegerleri{Id = 10, Adi = "Cenk"},
                });

            //musteriler.Clear();

            int MusteriSayisi = musteriler.Count();
            Console.WriteLine("Toplam Müşteri Sayisi: {0}", MusteriSayisi);

            bool icindeVarmi = musteriler.Contains(musteriDegerleri1);
            Console.WriteLine("Liste İçinde değer var mı diye bakıldı '{0}' sonucu döndürüldü", icindeVarmi);

            bool icindeVarmi2 = musteriler.Contains(new MusteriDegerleri { Id = 8, Adi = "Özge" });
            Console.WriteLine("Liste İçinde değer var mı diye bakıldı '{0}' sonucu döndürüldü", icindeVarmi2);


            int indexBilgisi = musteriler.IndexOf(musteriDegerleri1);
            Console.WriteLine("IndexOf ile index değeri alındı '{0}' sonucu döndürüldü", indexBilgisi);

            int indexBilgisi2 = musteriler.LastIndexOf(musteriDegerleri1);
            Console.WriteLine("LastIndexOf ile index değeri alındı '{0}' sonucu döndürüldü", indexBilgisi2);



            musteriler.Insert(0, musteriDegerleri1);

            musteriler.Remove(musteriDegerleri1);

            musteriler.RemoveAll(m => m.Adi == "Ege");

            foreach (MusteriDegerleri musteri in musteriler)
            {
                Console.WriteLine("Müşteri ID: {0}, Müşteri Adı: {1}", musteri.Id, musteri.Adi);
            }
            Console.ReadLine();
        }
    }

    class MusteriDegerleri
    {
        public int Id { get; set; }

        public string Adi { get; set; }
    }
}