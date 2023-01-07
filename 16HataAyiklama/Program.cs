namespace _16HataAyiklama
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
				string[] ogrenciler = new string[3] { "İlker", "İlknur", "Firdevs" };
				ogrenciler[3] = "Muhuttin";

				Console.ReadLine();
			}
			catch (Exception hataBilgisi)
			{
				Console.WriteLine("Hata Var Sorun: {0}", hataBilgisi.Message);
                Console.WriteLine("Hata Var Satır ve Konum Bilgisi: {0}", hataBilgisi.StackTrace);
                Console.WriteLine("Hata Var Detay: {0}", hataBilgisi.InnerException);
                Console.WriteLine("Hata Var YArdım Linki: {0}", hataBilgisi.HelpLink);

                Console.ReadLine();
            }
        }
    }
}