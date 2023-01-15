using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.StaticClasses
{
    internal class SstTekHelper
    {
        public static string? Name = "Static Class";
        public static int? Age = null;

        public const string Mail = "";

        public static int Topla(int x, int y)
        {
            return x + y;
        }

        public static ResponseModel Divide(int x, int y)
        {
            
            /*if (y == 0)
            {
                throw new Exception(message: "second parameter can not be equal to zero!"); //bu da bi yöntem
            }
            return x / y;*/
            try
            {
                var result = x / y;
                return new ResponseModel
                {
                    Result = result,
                    Message = "Succes"
                };
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                return new ResponseModel
                {
                    Message = e.Message
                };
               
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                return new ResponseModel
                {
                    Message = e.Message
                };
                

            }
            // arka arkaya birden fazla catch bloğu ekleyebiliriz !!!

            finally
            {
                Console.WriteLine("Program End!");
                //koddaki şey çalışşsa da(try) çalışmasa da(catch) şu işlemi(finally) yap !!!
                // try bloğunu beklemez çalışır. O sebeple try içini beklemeden yazılabilir. Asenkron çalışır.
                // finally try ve catch bloklarından bağımsız çalıştığı için.
            }
    }
}
    

    public class TestClass
    {
        public int Count { get; set; }
        public string Name { get; set; }
    }

    /* TEKRAR DERSİ NOTLARI 
     * 
     * 
     *
     
     ***REF***
    int a = 0  **önceden tanımlamamız gerekti !!!
    toplama_fonsiyonu_ama_void (a)
    return a = hala 0;

    toplama_fonsiyonu_ama_void (ref a)
    return a = 1 olur

    yani ref olarak verirsek buradaki a nın adresini verdiğinden buradaki a değişir aksi şekilde
    yapılan işlemler fonskiyonun içinde kaldığı için, return eden değer olmadığı için değişmez.

    ***OUT***
    çıkartma_foıksiyonu_ama_void(10, out int result)
    out int result = sen bu işlemi yap resulta ata ben bunu sonra kullanıcam demek 
    ** önceden tanımlamamız gerekmedi, işlem yapılırken çalışırken oluşturulu !!!
    print result --> 9 geldi

    ***ENUM***
    string ifadeye sayısal değer verimek ve buna dair işelmeler yapılabilir.Eğer değeri biz vermezsek isek
    default olarak 0, 1, 2,... şeklinde numaralandırılır.
    
     ***INTERNAL***
     aynı program içerisinden erişilebilir, fakat farklı bir program içerisinden erişilemez durumdadır.
    farklı namescape tarafından eişilmez. hiçbişi yazmazsak default olarak internal gelir.

    private dan farkı : bir class private olarak tanımlanmaz. Bir classın içindeki alanlar için kullanilabilir.
    internal class bazında saklama sağlar. Classın privateı gibi gibi :) 

    ***aynı şekilde protected da bir class için kullanılmaz! protected, benden türeyenlerde görülsün demek.
    yani miras alınanlarda görülebilir ama private öyle değil. 
    
    ***protected internal : aynı şekilde farklı namespace de görülmez,çağırılamaz. Aynı protected gibi davrnaır.
     
    *
    *
    *
    */
}
