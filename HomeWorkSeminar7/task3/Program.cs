/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
                Console.WriteLine("Ввели некоректное числою Повторите ввод:");
            }
    }
    return result;
}

int[,] InitFillMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(1,10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}, ");
        }
        Console.WriteLine();
    }
}


void AverageMatrix(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double avarage = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                avarage = (avarage + matrix[i, j]);
            }
            avarage = (avarage / matrix.GetLength(0));
            Console.Write(Math.Round(avarage, 1) + ",");
        }    
}

int rows = GetNumber("Введите количество строк:");
int columns = GetNumber("Введите количество столбцов:");
 
int[,] matrix = InitFillMatrix(rows, columns);
PrintMatrix(matrix);

AverageMatrix(matrix);

