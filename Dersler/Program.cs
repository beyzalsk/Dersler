using System;

namespace Dersler
{
    class Program
    {
        static void Main(string[] args)
        { // type safety tip güveliği demek
          // değer tutucu, alias
            string kategoriEtiketi = "Kategori";
            int öğrencisayısı = 32000;
            double faizoranı = 1.45;
            bool sistemegirisyapmıs = false; // boolen 
            double dolardun = 5.12;
            double dolarbugün = 5.52;

            if (dolardun > dolarbugün)
            {
                Console.WriteLine("Azalış butonu");

            }
            else if (dolardun < dolarbugün)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            if (sistemegirisyapmıs == true) // iki taba bas
            {
                Console.WriteLine("Kullanıcı ayarşları butonu");

            }
            else
            {
                Console.WriteLine("Giriş yap butonu")
;
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
