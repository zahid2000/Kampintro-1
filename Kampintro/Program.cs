using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string girisEvet = "Sisteme Giriş Yapıldı"; //string düz yazı type
            string girisHayir = "Lütfen Giriş Yapınız";
            bool loginOldumu = false;
            double dolarDun = 7.45; //double ondalık sayı type
            double dolarBugun=7.45;

            if (dolarDun > dolarBugun) 
            {
                Console.WriteLine("Azalış Butonu");
            }
            


            if (loginOldumu==true)
            {
                Console.WriteLine(girisEvet);
            }
            else
            {
                Console.WriteLine(girisHayir);
            }

            string sonuc = (loginOldumu == false) ? "Giriş Yapamadınız" : "Giriş Başarılı";

            Console.WriteLine(sonuc);  


        }

        
	}

    
}
