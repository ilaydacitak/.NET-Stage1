using System;

namespace Academy.TypeAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi = 1; //32bit
            long sayi2 = 2; //64bit
            short sayi3 = 3; //16bit
            byte sayi4 = 4; //8bit

            double ondaliksayi = 100.6; // virgulden sonra 15 karaktere kadar izin verir. || 64bit
            decimal ondaliksayi2 = 100.8M; //M/m kullanımı zorunludur.
            float ondaliksayi3 = 100.4F; // F/f kullanımı zorunlu. || virgulden sonra 6/9 karakter arası için kullanılır.

            bool cinsiyet = true;
            bool cinsiyet2 = false;

            char yazi = 'A'; // tek karakter

            var deger = 10;
            var deger2 = "Battal";

            if (deger == (int)Akademi.Mustafa)
            {

            }

            Console.WriteLine(sayi);
            Console.ReadLine();
        }

    }
        enum Akademi
        {
            Battal = 10,
            Merve = 30,
            Mustafa = 40
        }
    
}
