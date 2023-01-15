using Academy.General;

void AsIs()
{
    Object[] dizi = { "Kamet", "Onur", 5, 99, false, "Nisa" };

    foreach (var item in dizi)
    {
        if (item is string)
        {
            string x = item as string;
            Console.WriteLine("bu bir string :" + x);
        }
    }
}

//AsIs();

//Implicit => kapalı dönüşüm => veri kaybı yaşanmaz
//Explicit => açık dönüşüm => veri kaybı yaşanabilir, tipi belirtmeliyiz

int sayi = 100;
long sayiLong = sayi;

long sayi2 = 500;
int sayiInt = (int)sayi2;

int sayi3 = 300;
byte sayiByte = (byte)sayi3; //neden 256 olmadı

Console.WriteLine("sayi :" + sayiByte);

//Boxing => value => reference
// Unboxing => reference => value

//int, long, byte, decimal, double, bool, float => stack
//class, interface, string, object => heap

int deger = 100;
object obj = deger; //Boxing

object obj2 = 200;
int degerInt = (int)obj2; //Unboxing

//Const / readyonly

var pageKey = Settings.PAGEKEY;

Settings settings = new Settings(DateTime.Now.ToString());

//settings._aktifZaman = "deneme";
var zaman = settings._aktifZaman;
//Cast

long sayi5 = 500;
//int sayiInt2 = (int)sayi5;

int sayiInt2 = Convert.ToInt32(sayi5);
bool isAktif = Convert.ToBoolean(0);
int sayi10 = Convert.ToInt32("36");

// Console.WriteLine("aktif mi :" + isAktif);
// Console.WriteLine("sayi :" + sayi10);

//Parse / TryParse

var ss = int.Parse("90");

string yeniSayi = "dilara";
int result;

var cevirdimi = int.TryParse(yeniSayi, out result);

Console.WriteLine("sayi :" + result);
Console.WriteLine("cevirdimi :" + cevirdimi);

string s1 = sayi5.ToString();
