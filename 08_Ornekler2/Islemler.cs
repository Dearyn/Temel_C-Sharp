using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Ornekler2
{
    internal class Islemler
    {
        public void BagdasikSayiBulma(int sayi1, int sayi2)
        {
            if(sayi1>=10 && sayi2>=10 && sayi1<=100 && sayi2 <= 100)
            {
                int sayi1b = sayi1 % 10;
                int sayi2b = sayi2 % 10;

                if (sayi1b + sayi2b == 10)
                {
                    int sayi1o = sayi1 / 10;
                    int sayi2o = sayi2 / 10;

                    if (sayi1o == sayi2o)
                    {
                        Console.WriteLine("Bu iki sayı bağdaşıktır");
                    }

                    else
                    {
                        Console.WriteLine("Bu iki sayı bağdaşık değildir");
                    }
                }

                else
                {
                    Console.WriteLine("Bu iki sayı bağdaşık değildir");
                }
            }

            else
            {
                Console.WriteLine("Lütfen 10 ile 100 arasında bulunan iki basamakl bir doğal sayı giriniz! ");
            }
        }
    }
}
