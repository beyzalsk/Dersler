using System;

namespace classıntro
{
    class Program
    {
        static void Main(string[] args) { 


            string adi = "Beyza";
            int yas = 15;

            
            Kurs krs1 = new Kurs();
            krs1.kursadi = "c#";
            krs1.egitmen = "Engin";
            krs1.izlenme = 12;

            Kurs krs2 = new Kurs();
            krs2.kursadi = "java";
            krs2.egitmen = "berkay";
            krs2.izlenme = 13;

            Kurs krs3 = new Kurs();
            krs3.kursadi = "c";
            krs3.egitmen = "Emre";
            krs3.izlenme = 14;
            // Console.WriteLine(krs2.izlenme + " " + krs2.kursadi);

            Kurs[] kurslar = new Kurs[] { krs1, krs2, krs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursadi );
            }

        }
    }
    class Kurs
    {
    public string kursadi{ get; set; }
    public string egitmen { get; set; }
    public int izlenme { get; set; }

    }
    }
