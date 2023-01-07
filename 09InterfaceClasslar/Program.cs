namespace _09InterfaceClasslar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Islemler islemler = new Islemler();
            Islemler islemler2 = new();

            islemler.Ekleme(new Musteri { Id = 1, Adi = "İlker", Soyadi = "Ulaş" });//Birinci Yöntem
            Musteri musteri = new Musteri 
            {
                Id = 1,
                Adi = "İlker",
                Soyadi="Ulaş",
                MusteriAdresi="Altınova Mahallesi",
            };//İkinci Yöntem
            islemler.Ekleme(musteri);

            Musteri musteri2 = new Musteri(); //Üçüncü Yöntem
            musteri2.Id = 1;
            musteri2.Adi = "İlker";
            musteri2.Soyadi = "Ulaş";
            musteri2.MusteriAdresi = "Altınova Mahallesi";
            islemler2.Ekleme(musteri2);

            Console.WriteLine(musteri);
            Console.WriteLine(musteri2);

            Calisan calisan = new Calisan { Id = 1, Adi = "İlker", Soyadi = "Ulaş" };
            islemler.Duzenle(calisan);
        }
    }

    interface IInsan
    {
        public int Id { get; set; }

        public string Adi { get; set; }

        public string Soyadi { get; set; }
    }

    class Musteri : IInsan
    {
        public int Id { get; set; }

        public string Adi { get; set; }

        public string Soyadi { get; set; }

        public string MusteriAdresi { get; set; }
    }

    class Calisan : IInsan
    {
        public int Id { get; set; }

        public string Adi { get; set; }

        public string Soyadi { get; set; }

        public string Departman { get; set; }
    }

    class Islemler
    {
        public void Ekleme(Musteri gelenDeger)
        {
            Console.WriteLine("Eklendi");
        }

        public void Duzenle(IInsan gelenDeger)
        {
            Console.WriteLine("Düzenlendi");
        }
    }
}