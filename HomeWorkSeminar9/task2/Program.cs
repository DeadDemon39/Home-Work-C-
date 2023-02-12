/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {   
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели некоректное число. Повторите ввод:");
        }
    }
    return result;
}


int NumRec(int m, int n)
{
    int sum = 0;
    if (m <= n) return sum += m + NumRec(m + 1, n);
    else return 0;    
}

int m = GetNumber("Введите число:");
int n = GetNumber("Введите число:");

Console.WriteLine(NumRec(m, n));