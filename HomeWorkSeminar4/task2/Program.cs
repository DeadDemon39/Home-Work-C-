/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/


int GetNumber(string message)
{
    int number = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out number))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод: ");
        }
    }
    
    return number;
}

int GetSumm(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int num = number % 10;
        number = number / 10;
        sum = sum + num;
    }
        
    return sum;
}

int number = GetNumber("Введите число");
Console.WriteLine(GetSumm(number));

