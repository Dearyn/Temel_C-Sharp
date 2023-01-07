namespace _09zOrnekler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robotlar robot1 = new Robotlar();
            robot1.SeriNo = 14973;

            Calisanlar calisan1 = new Calisanlar();
            calisan1.Adi = "İlker";
            calisan1.Soyadi = "Ulaş";

            Yoneticiler yonetici1 = new Yoneticiler();
            yonetici1.Adi = "İlker";
            yonetici1.Soyadi = "Ulaş";
        }
    }

    interface IYemek
    {
        void Yemek();// Otak kullanılacak Methodlar
    }

    interface IYonet
    {
        void Yonet();// Otak kullanılacak Methodlar
    }

    interface ICalis
    {
        void Calis();// Otak kullanılacak Methodlar
    }

    interface IDinlen
    {
        void Dinlen();// Otak kullanılacak Methodlar
    }

    interface ISarjOl
    {
        void Sarj();// Otak kullanılacak Methodlar
    }

    interface IInsan
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }

    }

    class Yoneticiler: IYemek, IYonet, IDinlen, IInsan
    {
        public void Yemek() { Console.WriteLine("Yemek Yedim"); }
        public void Yonet() { Console.WriteLine("Yönettim"); }
        public void Dinlen() { Console.WriteLine("Dinlendim"); }

        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }

    class Calisanlar : IYemek, ICalis, IDinlen, IInsan
    {
        public void Yemek() { Console.WriteLine("Yemek Yedim"); }
        public void Calis() { Console.WriteLine("Calistim"); }
        public void Dinlen() { Console.WriteLine("Dinlendim"); }

        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }


    class Robotlar : ICalis, ISarjOl
    {
        public void Calis() { Console.WriteLine("Calistim"); }
        public void Sarj() { Console.WriteLine("Dinlendim"); }

        public int SeriNo { get; set; }

    }

}