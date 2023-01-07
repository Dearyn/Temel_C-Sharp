namespace _08_Ornekler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MatematikselIslemler mat = new MatematikselIslemler();

            Urun urun1 = new Urun();

            urun1.Id = 163487;
            urun1.Adi = "Laptop";
            urun1.Adet = 3;
            urun1.KdvOran = 18;
            urun1.Fiyat = 15638;
            urun1.AraToplamFiyat = urun1.Fiyat * urun1.Adet;
            urun1.KdvFiyati = mat.KdvFiyatHesapla(urun1.AraToplamFiyat, urun1.KdvOran);
            urun1.GenelToplamFiyat = urun1.AraToplamFiyat + urun1.KdvFiyati;


            Console.WriteLine("{0} Id'li {1} ürünün {2} adet {3} fiyattan satış işlemi sonrası {4} KDV oranı ile ara toplam {5}, KDV {6}, genel toplam {7} TL dir", urun1.Id, urun1.Adi, urun1.Adet, urun1.Fiyat, urun1.KdvOran, urun1.AraToplamFiyat, urun1.KdvFiyati, urun1.GenelToplamFiyat);

            Console.ReadLine();


        }
    }
}