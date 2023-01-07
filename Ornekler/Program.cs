namespace Ornekler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. İlk gün 50 sayfa okuduğumuz 900 sayfalık bir kitabı, daha sonra her gün 30 sayfa okuyarak kaç günde bitiririz diye hesaplayan program.

            //GunHesapla();


            // 2. 50 ile 100 arasındaki 3'e tam bölünebilen sayıların toplamını hesaplayan program.

           // ToplamBul();


            //3.  Değişkene atanan ürün fiyatını değişkene atanan ürün adeti ile çarpıp, KDV(%18) ekleyerek ekrana yazdıran program.

            FiyatHesapla();
        }
        static void GunHesapla()
        {
            int toplamSayfaSayisi = 900;
            int ilkGunOkunanSayfaSayisi = 50;
            int hergunOkunanSayfaSayisi = 30;
            int gun = 0;

            int kalanSayfaSayisi = toplamSayfaSayisi - ilkGunOkunanSayfaSayisi;

            while(kalanSayfaSayisi > 0)
            {
                kalanSayfaSayisi-=hergunOkunanSayfaSayisi;
                gun++;
            }

            Console.WriteLine("{0} sayfalık bir kitabı ilk gün {1} sayfa okuyup devamında hergün {2} sayfa okuyarak {3} günde birtirebilirsiniz", toplamSayfaSayisi, ilkGunOkunanSayfaSayisi, hergunOkunanSayfaSayisi, gun);
            Console.ReadLine();
        }

        static void ToplamBul()
        {
            int toplam = 0;
            int ilkSayi = 50;
            int ikinciSayi = 100;

            for (int i = ilkSayi; i < ikinciSayi; i++)
            {
                if (i%3==0)
                {
                    toplam += i;
                }
            }

            Console.WriteLine("{0} ile {1} arasındaki 3'e tam bölünebilen sayıların toplamı: {2}", ilkSayi, ikinciSayi, toplam);
            Console.ReadLine();
        }

        static void FiyatHesapla()
        {
            /*string urunAdi = "Asus Laptop";
            double urunFiyat = 5000;
            int urunAdet = 3;
            int kdvOran = 18;

            double urunToplamFiyat = urunFiyat * urunAdet;

            double kdvMiktari = (urunToplamFiyat * kdvOran) / 100;

            double genelToplam = urunToplamFiyat + kdvMiktari;

            Console.WriteLine("Fiyatı {0} TL olan, {1} isimli üründen, {2} adet aldığınızda faturanız {3} TL dir buna %{4}'lik KDV oranı eklendiğinde ödeyeceğiniz toplam miktar {5} TL'dir", urunFiyat, urunAdi, urunAdet, urunToplamFiyat, kdvOran, genelToplam);
            Console.ReadLine();*/

            // Kullanıcıdan data alma yöntemli

            Console.Write("Ürün Adı Giriniz: ");
            string urunAdi = Convert.ToString(Console.ReadLine());

            Console.Write("Ürün Fiyatı Giriniz: ");
            double urunFiyat = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ürün Adeti Giriniz: ");
            int urunAdet = Convert.ToInt32(Console.ReadLine());

            int kdvOran = 18;

            double urunToplamFiyat = urunFiyat * urunAdet;

            double kdvMiktari = (urunToplamFiyat * kdvOran) / 100;

            double genelToplam = urunToplamFiyat + kdvMiktari;

            Console.WriteLine("Fiyatı {0} TL olan, {1} isimli üründen, {2} adet aldığınızda faturanız {3} TL dir buna %{4}'lik KDV oranı eklendiğinde ödeyeceğiniz toplam miktar {5} TL'dir", urunFiyat, urunAdi, urunAdet, urunToplamFiyat, kdvOran, genelToplam);
            Console.ReadLine();
        }

    }
}