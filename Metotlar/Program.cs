using System;

namespace Metotlar
{
    class Program
    {


        static void Main(string[] args)
        {
            // Property - özellik   
            string adi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            Product urun1 = new Product();
            urun1.Adi = "Armut";
            urun1.Aciklama = "Amasya armutu";
            urun1.Fiyati = 15;

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 16;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Product[] urunler = new Product[] { urun1, urun2 };
            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------");

            }

            Console.WriteLine("-------------Metotlar---------");

            SepetManager sepetManger = new SepetManager();
            sepetManger.Ekle(urun1);
            sepetManger.Ekle(urun2);

            sepetManger.Ekle2("Elma", "Yeşil Elma", 14);
            sepetManger.Ekle2("Armut", "Armute", 23);





        }
    }
}
