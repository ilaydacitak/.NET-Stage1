using System;

namespace Academy.Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            char c = 'a';
            string name = "Ahmet";
            string lastname = "Türkoğlu";

            string template = "Merhaba {0} {1}";
            //var result = name + " " + lastname;

            string result = string.Empty;

            result = string.Format(template, name, lastname);


            string cümle = "merhaba arkadaşlar ders devam ediyor.";

            var sayi = cümle.Length;

            var cümle2 = cümle.Clone();


            var cümle3 = cümle.Replace("dersimiz", "devam");

            var sDizi = cümle.Split(" ");

            var subCümle = cümle.Substring(0, 7);

            var tCumle = cümle.Trim();
            //var tCumle = cümle.TrimEnd();
            //var tCumle = cümle.TrimStart();

            var tCumle2 = tCumle.ToUpper();
            //var tCumle2 = tCumle.ToLower();

            var varMi = cümle.EndsWith("e");
            //var varMi = cümle.StartsWith("e");




        }
    }
}
