namespace _02SartBloklari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 20;
            int sayi2 = 30;
            int sayi3 = 40;

            if(sayi1 < sayi2)
            {
                Console.WriteLine("Sayı 1 sayı 2 den küçüktür. Sayı 1: {0}, Sayı 2: {1}", sayi1, sayi2);
            }
            else
            {
                Console.WriteLine("Sayı 2 sayı 1 den küçüktür veya eşittir. Sayı 1: {0}, Sayı 2: {1}", sayi1, sayi2);
            }

            if(sayi3 <sayi1 || sayi3 < sayi2)
            {
                Console.WriteLine("Sayı 3 sayı 1 veya sayı 2 den küçüktür");
            }
            else
            {
                Console.WriteLine("Sayı 3 sayı 1 veya sayı 2 den büyüktür");
            }

            Console.ReadLine();

            int switchSayimiz = 10;

            switch (switchSayimiz)
            {
                case 10: //Sayımızın 10 olma durumunda çalışır
                    Console.WriteLine("Sayımız 10'dur");
                    break;

                case 20:
                    Console.WriteLine("Sayımız 10'dur");
                    break;

                default:
                    Console.WriteLine("Sayımız 10 veya 20 değildir");
                    break;
            }
            Console.ReadLine();
        }
    }
}