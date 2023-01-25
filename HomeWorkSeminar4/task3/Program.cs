/*
 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/


int[] GetMassive()
{
    int [] newMassive = new int [8];
    Random number = new Random();

    for (int i = 0; i < newMassive.Length; i++)
    {
       newMassive[i] = number.Next(0, 10);
     
    }
    return newMassive;
    
}
int [] massive = GetMassive();

void PrintMassive(int [] massive)
{
    for (int i = 0; i < massive.Length; i++)
    {
       Console.Write($"{massive[i]}" + ","); 
    }
}

PrintMassive(massive);