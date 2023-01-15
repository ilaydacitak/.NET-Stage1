// See https://aka.ms/new-console-template for more information
using Academy.StaticClasses;

var result = SstTekHelper.Topla(1,2);

var firstValue = Convert.ToInt32(Console.ReadLine());
var secondValue = Convert.ToInt32(Console.ReadLine());
var divideResult = SstTekHelper.Divide(firstValue, secondValue);

Console.WriteLine($"{ result}");
Console.WriteLine($"{SstTekHelper.Name}");

Console.WriteLine($"{divideResult}");
Console.ReadLine();