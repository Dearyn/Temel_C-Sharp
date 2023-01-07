namespace _08ClasslarProperty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "İlker";
            musteri1.Soyad = "Ulaş";
            musteri1.Sehir = "Tekirdağ";

            Console.WriteLine(musteri1.Ad);

        }
    }
}