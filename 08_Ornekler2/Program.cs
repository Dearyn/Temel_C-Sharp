namespace _08_Ornekler2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Islemler islemler = new Islemler();
            Sayilar sayilar = new Sayilar();

            Console.Write("Birinci sayıyı giriniz: ");
            sayilar.Sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci sayıyı giriniz: ");
            sayilar.Sayi2 = Convert.ToInt32(Console.ReadLine());

            islemler.BagdasikSayiBulma(sayilar.Sayi1, sayilar.Sayi2);

            Console.ReadLine();
        }
    }
}