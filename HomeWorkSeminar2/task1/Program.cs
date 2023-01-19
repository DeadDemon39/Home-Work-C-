/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

// первый способ:
 Console.WriteLine("Введите трехзначное число: ");

 string a = Console.ReadLine();   

  Console.WriteLine(a[a.Length - 2]);



// второй способ:
Console.WriteLine("Введите трехзначное число: ");

int a = Convert.ToInt32(Console.ReadLine());

int b = (a / 10) % 10;

Console.WriteLine(b);
