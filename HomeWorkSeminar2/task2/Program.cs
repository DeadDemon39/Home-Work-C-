/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.WriteLine("Введите число ");

int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number); // решенеие за счет конвертирования числовой переменной в строку

if (numberText.Length > 2)
{
  Console.WriteLine("третья цифра  " + numberText[2]);
}
else 
{
  Console.WriteLine("третьей цифры нет");
}