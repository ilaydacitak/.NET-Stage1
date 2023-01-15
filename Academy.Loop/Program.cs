using System;

namespace Academy.Loop
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] isimler = { "ahmet", "mehmet", "veli", "cenk" };

            for (int a = 0; a < isimler.Length; a++)
            {
                Console.WriteLine(a);
            }

            var IsAktif = true;
            var i = 1;
            var dongusayisi = 1;
            while (IsAktif) // (i>100) gibi farklı şartlar da yazılabilir.
            {
                i++;
                if (i == 10)
                {
                    Console.WriteLine(i);
                    IsAktif = false;
                }
                    
            }

            do
            {

                dongusayisi++;
                Console.WriteLine(dongusayisi);
                i++;
                
                if (i == 10)
                {
                    Console.WriteLine(i);
                    IsAktif = false;
                }

            } while (IsAktif);

            foreach (var item in isimler)  // itemler okunur ama döngü içerisinde değeri değğiştiremem
                                           // okunurken readonly olur
            {
                Console.WriteLine(item);
            }

        }
    }
}