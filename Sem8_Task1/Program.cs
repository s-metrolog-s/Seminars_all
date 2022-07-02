//Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет 
// местами первую и последнюю строку массива.

Random rand = new Random();
int m = rand.Next(2, 10);
int n = rand.Next(2, 10);
int[,] matrix = new int[m, n];

Console.Clear();
Console.WriteLine($"*************************************************");
Console.WriteLine($"Дан массив на {m} строк (-и) и {n} столбца (-ов)");
Console.WriteLine($"*************************************************");

FillArray(matrix);
PrintArray(matrix);

Console.WriteLine($"*************************************************");

SwopRows(matrix, 0, matrix.GetLength(0) - 1);
PrintArray(matrix);

Console.WriteLine($"*************************************************");

void FillArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(1, 10);
        }
    }
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void SwopRows (int[,] array, int first, int second)
{
    int temp;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        temp = array[first, j];
        array[first, j] = array[second, j];
        array[second, j] = temp;
    }
}