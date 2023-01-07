namespace _01VeriTipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba İlk Consol Uygulaması");

            int number1 = 2147483647; // integer +2147483647 ve -2147483647 arasındaki sayıları ifade eder. Bellekte 32 bit yer kaplar.
            int number2 = -2147483647; // integer +2147483647 ve -2147483647 arasındaki sayıları ifade eder. Bellekte 32 bit yer kaplar.
            long number3 = 21474832323648; // long +21474832323648 ve -21474832323648 arasındaki sayıları ifade eder. Bellekte 64 bit yer kaplar.
            long number4 = -21474832323648; // long +21474832323648 ve -21474832323648 arasındaki sayıları ifade eder. Bellekte 64 bit yer kaplar.
            short number5 = 32767;  // short +32767 ve -32768 arasındaki sayıları ifade eder. Bellekte 16 bit yer kaplar.
            short number6 = -32768;  // short +32767 ve -32768 arasındaki sayıları ifade eder. Bellekte 16 bit yer kaplar.
            byte number7 = 255;  // byte 0 ve 255 arasındaki sayıları ifade eder. Bellekte 8 bit yer kaplar. 
            bool dogruMu = true; // bool veri tipi sadece true yada false değerlerini alır.
            char karakter = 'a'; // char veri tipi klavyenizde bulunan tek bir karakteri tutabilir.
            string karakterler = "İlker"; // string için harfleri tutabilen bir dizi diyebiliriz.String kelime yazımları çin uygundur.
            double number8 = 10.5; // double ondalık sayıları tutmakte kullanılır. Virgülden sonra 15-16 karakter tutar. Bellekte 64 bit yer kaplar.
            decimal number9 = 4232124124.12323232m; // decimal virgülden sonra 28-29 karakter tutar. Bellekte 128 bit yer kaplar.
            var veriTipiNey = 10; //var atanmış olan değere göre  ototmatk olarak veri tipi taımlanır.
            var veriTipiNey2 = "İlker";

            Console.WriteLine("Sayı 1: {0}", number1);
            Console.WriteLine("Sayı 2: {0}", number2);
            Console.WriteLine("Sayı 3: {0}", number3);
            Console.WriteLine("Sayı 4: {0}", number4);
            Console.WriteLine("Sayı 5: {0}", number5);
            Console.WriteLine("Sayı 6: {0}", number6);
            Console.WriteLine("Sayı 7: {0}", number7);
            Console.WriteLine("Doğrumu 1: {0}", dogruMu);
            Console.WriteLine("Karakter {0}", karakter);
            Console.WriteLine("Karakterler {0}", karakterler);
            Console.WriteLine("Sayı 8: {0}", number8);
            Console.WriteLine("Sayı 9: {0}", number9);
            Console.WriteLine("Veri Tipi {0}", veriTipiNey);
            Console.WriteLine("Veri Tipi 2: {0}", veriTipiNey2);


            Console.ReadLine();

        }
    }
}