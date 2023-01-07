namespace _06StringMethodlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cumle = "Merhaba Dünya!";
            var sonuc = cumle.Length; //Karakter sayısı alabiliriz.
            Console.WriteLine(sonuc);
            Console.WriteLine("######################");


            var sonuc2 = cumle.Clone();//Bir değişkenin içeriğini klonlamakta kullanılır
            Console.WriteLine(sonuc2);
            Console.WriteLine("######################");


            bool sonuc3 = cumle.EndsWith("ğ");//Bu değişkenin sonu ğ ile bitiyor mu onu kontrol eder. bitiyor ise true bitmiyor ise false döndürür
            bool sonuc4 = cumle.StartsWith("ğ");//Bu değişkenin sonu ğ ile başlıyor mu onu kontrol eder. başlıyor ise true başlamıyor ise false döndürür
            Console.WriteLine(sonuc3);
            Console.WriteLine(sonuc4);
            Console.WriteLine("######################");


            var sonuc5 = cumle.IndexOf("Dünya");//Bir stringe belli bir karakteri veya ifadeyi aratmak için kullanılır. Eğer aratılan şey ifadenin içinde varsa başladığı indexi bize döndürür
            Console.WriteLine(sonuc5);
            Console.WriteLine("######################");

            var sonuc6 = cumle.IndexOf(" ");//Bir stringe belli bir karakteri veya ifadeyi aratmak için kullanılır. Eğer aratılan şey ifadenin içinde varsa başladığı indexi bize döndürür
            Console.WriteLine(sonuc6);
            Console.WriteLine("######################");


            var sonuc7 = cumle.LastIndexOf(" ");//Bir stringe belli bir karakteri veya ifadeyi sondan başlayarak aratmak için kullanılır. Eğer aratılan şey ifadenin içinde varsa başladığı indexi bize döndürür
            Console.WriteLine(sonuc7);
            Console.WriteLine("######################");


            var sonuc8 = cumle.Insert(0, "Hoşgeldin, ");//Insert ile string değişkenine kaçıncı index değerinden sonra istediğimiz metini eklememii sağlar
            Console.WriteLine(sonuc8);
            Console.WriteLine("######################");


            var sonuc9 = cumle.Substring(8);//Substring belirlenen indexten sonrak kısmı yazdırır
            Console.WriteLine(sonuc9);
            Console.WriteLine("######################");

            var sonuc10 = cumle.Substring(8,5);//Substring belirlenen indexten sonrak kısmı ikşnci girilern index sayısını
            Console.WriteLine(sonuc10);
            Console.WriteLine("######################");


            var sonuc11 = cumle.ToLower();//ToLower değişkendeki tüm karakterleri küçültür
            Console.WriteLine(sonuc11);
            Console.WriteLine("######################");


            var sonuc12 = cumle.ToUpper();//ToLower değişkendeki tüm karakterleri büyültür
            Console.WriteLine(sonuc12);
            Console.WriteLine("######################");


            var sonuc13 = cumle.Replace(" ","-");//Replace değişkendeki aratığımız değişkenleri ikinci atadığımız karaktere dönüştürür
            Console.WriteLine(sonuc13);
            Console.WriteLine("######################");


            var sonuc14 = cumle.Remove(7);//Remove belirttiğimiz indexten sonrasını siler
            Console.WriteLine(sonuc14);
            Console.WriteLine("######################");


            var sonuc15 = cumle.Remove(7,6);//Remove belirttiğimiz indexten sonrasını belirttiğimiz index sayısı kadar siler.
            Console.WriteLine(sonuc15);
            Console.WriteLine("######################");


            Console.ReadLine();
        }
    }
}