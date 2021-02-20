using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılımcı geliştirme ";
            string kurs2 = "Programlamaya başlangıç";
            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);

            //array dizi

            string[] kurslar = new string[] {"Yazılımcı geliştirme " , "Programlamaya başlangıç" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar) // kurs yazan yeri  istediğini yazabilirsim

            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("Sayfa Sonu");
        }
    }
}
