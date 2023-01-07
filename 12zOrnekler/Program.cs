namespace _12zOrnekler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IslemYap islemYap = new IslemYap(5);
            islemYap.EkranaYaz();

            Console.ReadLine();
        }

    }
    class IslemYap
    {
        private int _toplam = 0;
        public IslemYap(int sayi1)
        {
            _toplam = sayi1;
            Console.WriteLine("Gönderdiğiniz değer: {0}", _toplam);
        }

        public IslemYap(int sayi1, int sayi2)
        {
            _toplam = sayi1 + sayi2;
            Console.WriteLine("{0} ve {1} sayısının toplamı: {2}", sayi1, sayi2, _toplam);
        }

        public IslemYap()
        {
            Console.WriteLine("Değer Gönderilmedi");
        }

        public void EkranaYaz()
        {
            for (int i = 1; i <= _toplam; i++)
            {
                Console.WriteLine("{0}-Merhaba", i);
            }
        }
    }


}