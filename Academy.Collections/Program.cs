using System.Collections;
using Academy.Collections;

string[] ogrenciler = { "Şevval", "Caner", "Ezgi" };
ogrenciler[0] = "Kamet";
//ogrenciler[0] = 5;
ogrenciler = new string[3];


ArrayList list = new ArrayList();

list.Add("Recep");
list.Add("Onur");

//Console.WriteLine(list.Contains("Recep3"));
list.Insert(1, "Dilara");

var result3 = list.Add(999);

list.Clear();

List<string> liste = new List<string>();
liste.Add("Emre");
liste.Add("Gizem");

List<string> liste2 = new List<string>();
liste2.Add("Dilara");
liste2.Add("Kamet");

liste.AddRange(liste2);
liste2.Clear();

Console.WriteLine("var mı: " + liste.Contains("Emre"));
liste.Remove("Emre");
var sayi = liste.Count;

//Sınıf Örneği
Customer c = new Customer()
{
    Id = 1,
    Name = "Caner",
    Email = "caner@gmail.com"
};
Customer c2 = new Customer()
{
    Id = 2,
    Name = "Onur",
    Email = "onur@gmail.com"
};
Customer c3 = new Customer()
{
    Id = 3,
    Name = "Tarık",
    Email = "tarik@gmail.com"
};

Customer c4 = new Customer();
c4.Id = 10;
c4.Name = "Doğukan";
c4.Email = "dogukan@gmial.com";


List<Customer> customerList = new List<Customer>()
{
    new Customer()
    {
        Id = 4,
        Name = "Emre",
        Email = "emre@gmail.com"
    }
};

customerList.Add(c);
customerList.Add(c2);
customerList.Add(c3);
customerList.Add(c4);

var cSayi = customerList.Count;
//customerList.Remove(c);

var result = customerList.Contains(c3);
Console.WriteLine("sonuc: " + result);

foreach (var customer in customerList)
{
    Console.WriteLine($"customer : {customer.Name}");
}

var price = 0M;

// List<PostalCodes> pCode = new List<PostalCodes>();
// foreach (var ulke in ulkeler)
// {
//     List<PostalCodes> p = DB.GetPostalCodeListByCountryId(ulke.id).Take(150);
//     pCode.AddRange(p);
// }

//p erişelemez
//if(pCode.Count > 0)
//return pCode;

//Dictionary
Dictionary<string, string> dic = new Dictionary<string, string>();

dic.Add("name", "ilayda");
dic.Add("email", "ilayda@gmail.com");

var dicResult = dic["name"];
Console.WriteLine($"dic result: {dicResult}");

Dictionary<string, int> dicInt = new Dictionary<string, int>();
dicInt.Add("name", 100);
dicInt.Add("email", 900);

foreach (var d in dic)
{
    Console.WriteLine($"dic item: {d.Key}");
}

Console.WriteLine("key var mı: " + dic.ContainsKey("name"));
Console.WriteLine("value var mı: " + dic.ContainsValue("esra"));

//Console.WriteLine($"customer sayi: {cSayi}");
//Console.WriteLine(list.Count);
