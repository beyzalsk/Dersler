using System;

namespace DegerveReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 12;
            int sayi2 = 56;
            sayi1 = sayi2;
            sayi2 = 45;

            int[] sayilar1 = new int[] { 2, 3, 4 };
            int[] sayilar2 = new int[] { 100,200,300 };

            sayilar1 = sayilar2;
            sayilar2[0] = 999;

        }
    }
}
