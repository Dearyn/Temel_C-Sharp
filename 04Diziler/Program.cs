namespace _04Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] ogrenciler = new string[3];

            //ogrenciler[0] = "İlker";
            //ogrenciler[1] = "İlknur";
            //ogrenciler[2] = "Firdevs";

            //foreach(var ogrenci in ogrenciler)// Forwach döngüsü ile ogrenciler dizisinde bulunan tum değerleri in ile ogrenci değişkenine atadık
            //{
            //    Console.WriteLine(ogrenci);
            //}


            //Diziler 2. Kullanım Örneği

            //string[] ogrenciler2 = new [] {"İlker","İlknur","Firdevs"} ;

            //foreach(var ogrenci in ogrenciler2)// Forwach döngüsü ile ogrenciler dizisinde bulunan tum değerleri in ile ogrenci değişkenine atadık
            //{
            //    Console.WriteLine(ogrenci);
            //}


            //Diziler 3. Kullanım Örneği

            //string[] ogrenciler3 = {"İlker","İlknur","Firdevs"} ;

            //foreach(var ogrenci in ogrenciler3)// Forwach döngüsü ile ogrenciler dizisinde bulunan tum değerleri in ile ogrenci değişkenine atadık
            //{
            //    Console.WriteLine(ogrenci);
            //}



            //IsımYazdir("İlker", "İlknur", "Firdevs");

            //Console.ReadLine();

            string[,] bolgeler = new string[7, 3]
            {
                {"İstanbul", "Edirne", "Tekirdağ" },
                {"Ankara", "Konya", "Kırıkkale" },
                {"Antalya", "Adana", "Mersin" },
                {"Rize", "Trabzon", "Samsun" },
                {"İzmir", "Muğla", "Manisa" },
                {"Muş", "Van", "Kars" },
                {"Şanlıurfa", "Mardin", "Gaziantep" },
            };

            //Console.Write(bolgeler[0,2]);

            for(int i = 0; i <= bolgeler.GetUpperBound(0); i++)
            {
                for(int j = 0; j <= bolgeler.GetUpperBound(1); j++)
                {
                    Console.WriteLine(bolgeler[i,j]);
                }
                Console.WriteLine("************");
            }
            Console.ReadLine();
        }

        /*static void IsımYazdir(params string[] isimler)
        {
            foreach(var isim in isimler)
            {
                Console.WriteLine(isim);
            }
        }*/
    }
}