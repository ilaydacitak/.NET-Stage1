using System;

namespace Academy.Methods
{
    class Program
    {
        public static void Main(string[] args)
        {
            Login(email:"ahmet@gmail.com",sifre:"1234",deger:30,aktifMi:true);

            var email = "ahmet@gmail.com"; // ref değeri vermek zorundayız.
            Register(ref email, sifre:"1234");

            Console.WriteLine("Dışarıdaki email:"+ email); // dışarıdakı ahmeti zeynep yaptık !!!

            //var email2 = "ahmet2@gmail.com"; // istersek veririz ama...
            //string email2; // istersek değer vermeyebiliyoruz.
            //Register2(out email2, sifre: "1234"); // 

            //Console.WriteLine("Dışarıdaki email:" + email2); // dışarıdakı ahmeti zeynep yaptık !!!

            int a = 10;
            int b = 20;
            int c = 30;
            
            int[] numbers = new [] { 10, 20, 30 };

            ParamsMethod(numbers);
            //ParamsMethod(numbers: a, b, c, 40 ,50); // NEDEN HATA VERDİ ?? 


            IsActive(); // bool methot


            // var result = AddBasket();
            var (isim, sayi) = AddBasket();

            Console.WriteLine(isim);
            Console.WriteLine(sayi);
            Console.ReadLine();

        }

        private static void Login(string email, string sifre, int deger, bool aktifMi = false)
        {
            if(email == "ahmet@gmail.com")
            {
                aktifMi = false; 
            }
            if (!aktifMi)
            {
                Console.WriteLine("Ahmet aktif değil !!! ");

                Console.ReadLine();
            }

            /*
             *Kullanıcının email bilgisini al
             *Kullanıcının şifresini al
             *Şifre kontrolu yap + KARAKTER KONROLU YAP(sonradan eklendi)(tektek eklemek sorun!!!)
             *METOT HALİNE GETİRİNCE TEK YERDE DEĞİŞİKLİK YAPIP HER ULAŞILAN YERDE DEĞİŞİKLİK
             *ELDE ETMEMİZ MÜMKÜNDÜR!!!
             *DB de sorgu yap
             *Yok ise uyarı; Var ise olumlu dönüş yap.
             */
        }

        private static void Register(ref string email, string sifre)
        {
            email = "zeynep@gmail.com";
            Console.WriteLine(email);
        }

        private static void Register(out string email, string sifre, bool calisanMi)
        {
            email = "zeynep@gmail.com";

            if(calisanMi)
            {
                email = "..";
            }
            Console.WriteLine(email);
        }

        //Farklı parametreler ile aynı ismi kullababildik. AYnı parametreler farklı tiplerde verilerek
        // verilerek de overlodaing yapılabilir.
        //Register and Register2 olayları farklı, bu farklı konu. Bu konu overloading.(?)


        private static void ParamsMethod(params int[] numbers) // ayrı ayrı int a ,int b , int c göndermek yerine params
        {
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }

        }


        private static bool IsActive()
        {
            return true;
        }

        private static Tuple<string, int> AddBasket()
        {
            return Tuple.Create("SSTTEK Akademi", 100);
        }



    }

}

