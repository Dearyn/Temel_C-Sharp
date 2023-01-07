namespace _05Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Foreach döngü örneği
            //ForeachDonguOrnek();

            //For döngü örneği
            //ForLoopOrnek();

            //While döngü örneği
            //WhileLoopOrnek();

            //DoWhile döngü örneği
            //DoWhileLoopOrnek();

            AsalSayiYazdir(23);
        }

        //private static void ForeachDonguOrnek()
        //{
        //    string[] ogrenciler = new string[3] { "İlker", "İlknur", "Firdevs" };
        //    foreach (var ogrenci in ogrenciler)
        //    {
        //        Console.WriteLine(ogrenci);
        //    }
        //    Console.WriteLine();
        //    Console.ReadLine();
        //}

        //private static void ForLoopOrnek()
        //{
        //    for (int i = 0; i <= 100; i++)
        //    {
        //        Console.WriteLine(i);
        //    }
        //    Console.WriteLine("Döngü Durdu");
        //    Console.ReadLine();
        //}

        //private static void WhileLoopOrnek()
        //{
        //    int adet = 100;
        //    while (adet >= 0)
        //    {
        //        Console.WriteLine(adet);
        //        adet--;
        //    }
        //    Console.WriteLine("Sayınız Bu {0}",adet);
        //    Console.ReadLine();
        //}

        //private static void DoWhileLoopOrnek()
        //{
        //    int sayimiz = 100;
        //    do
        //    {
        //        Console.WriteLine(sayimiz);
        //        sayimiz--;
        //    }while(sayimiz >= 0);

        //    Console.WriteLine("Sayınız Bu {0}", sayimiz);
        //    Console.ReadLine();
        //}

        static void AsalSayiYazdir(int sayi)
        {
            int sayac = 0;
            for (int i = 1; i <= sayi; i++)
            {
                if (sayi % i == 0)
                {
                    sayac++;
                }
            }

            if (sayac < 2)
            {
                Console.WriteLine("Bu sayı asaldır");
            }
            else
            {
                Console.WriteLine("Bu sayı asal değildir");
            }

            Console.ReadLine();
        }
    }
}