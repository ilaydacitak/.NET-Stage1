using System;

namespace Akademi.Conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            int deger = 1000;
            string name = "Ahmet";

            // < , > , == , <= , >= , gibi karşılaştırma işaretleri mevcuttur.

            if ( deger >= 1000)
            {
                Console.WriteLine("Pre. Hediye Çeki Kazandı.");
            }
            else if ( deger >=500 && deger <= 999)
            {
                Console.WriteLine("Hediye Çeki Kazandı.");
            }
            else if (deger==400 || name == "Ahmet")
            {
                Console.WriteLine("Süpriz Hediye Çeki Kazandı.");
            }
            else
            {
                Console.WriteLine("Başka Sefere...");
            }


            // ikisi aynı şey , farklı yazımı
            if (name == "Ahmet")
            {
                deger = 500;
            }
            else
            {
                deger = 400;
            }


            deger = name == "Ahmet" ? 500 : 400;


            // && = ve, tüm koşullar sağlanmalı
            // || = veya, koşullardan birisi sağlanması yeterlidir.


            switch(name)
            {
                case "Ahmet":
                    deger = 300;
                    break;

                case "Mehmet":
                    deger = 200;
                    break;

                case "Zeynep":
                    deger = 100;
                    break;

            }
        }
    }
}
