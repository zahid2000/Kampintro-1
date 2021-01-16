using System;

namespace ClassInfo
{
    class Program
    {
        static void Main(string[] args)
        {

            string adi = "fatih";
            int yasi = 31;

            Kurs kurs1 = new Kurs();

            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Fatih Demirören";
            kurs1.izlenmeOrani = 75;

            Kurs kurs2 = new Kurs();

            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Sinem Demirören";
            kurs2.izlenmeOrani = 90;

            Kurs kurs3 = new Kurs();

            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Beren Demirören";
            kurs3.izlenmeOrani = 100;

            Kurs kurs4 = new Kurs();

            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Berenn Demirören";
            kurs4.izlenmeOrani = 100;

            //Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ":" + kurs.Egitmen);
            }


            Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int izlenmeOrani { get; set; }
    }
}
