using System;

namespace Academy.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim = "Ahmet";

            //string[] isimler = new string[3] { "Ahmet", "Mehmet", "Veli" };

            string[] isimler = { "Ahmet", "Mehmet", "Veli", "Cenk" };

            isimler[0] = "Ahmet"; // tarzında yazılabilir.

            Console.WriteLine(isimler[4]); // hata veriir cünkü bu indiste bir eleman yok.

            string[,] isimler2 = new string[2, 3]
            {
                {"Ahmet", "Mehmet", "Veli"  },
                {"Ahmet", "Mehmet", "Ali"  },
            };

            
        }
    }
}
