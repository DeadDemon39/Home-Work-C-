/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/



int[,] InitMatrix(int rows, int columns) // Инициализируем двумерный массив(заполненный случайными числами)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix) // Выводим массив на консоль
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.Write("| ");
    }
}

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] finalMatrix)
{
  for (int i = 0; i < finalMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < finalMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      finalMatrix[i,j] = sum;
    }
  }
}


int[,] firstMatrix = InitMatrix(2, 2);
PrintMatrix(firstMatrix);


Console.WriteLine();

int[,] secondMatrix = InitMatrix(2, 2);
PrintMatrix(secondMatrix);
Console.WriteLine();

int[,] finalMatrix = new int[2, 2];

MultiplyMatrix(firstMatrix, secondMatrix, finalMatrix);
Console.WriteLine($"Произведение первой и второй матриц = ");
PrintMatrix(finalMatrix);
