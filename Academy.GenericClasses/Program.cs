using Academy.GenericClasses;
using Academy.GenericClasses.Helper;

string[] list = new[] { "Nisa", "Emre", "Şevval" };
int[] listInteger = new[] { 1, 2, 3 };


List<string> genericList = new List<string>();
foreach (var item in list)
{
    genericList.Add(item);
}

Tools tools = new Tools();
List<string> genericList2 = tools.CreateList(list);

foreach (var item in genericList2)
{
    Console.WriteLine("eleman: " + item);
}

List<int> genericListInt = tools.CreateList(listInteger);
foreach (var item in genericListInt)
{
    Console.WriteLine("eleman: " + item);
}

Object[] dizi = { "Merve", 4, false, null };

int? a = null;
string s = null;
