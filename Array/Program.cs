using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

int[] numbers = new int[10];
for (int i = 0; i < numbers.Length; i++)
{
    Random rnd = new Random();
    int ranNum = rnd.Next(0, 1000);
    numbers[i] = ranNum;
}
Console.WriteLine("diziye 11. tam sayı elemanı giriniz:");
int el11th = Convert.ToInt32(Console.ReadLine());
numbers = numbers.Concat(new int[] { el11th }).ToArray();
Array.Sort(numbers);
Array.Reverse(numbers);
foreach (int i in numbers)
{
    Console.WriteLine(i);
}