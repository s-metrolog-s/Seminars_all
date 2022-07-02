// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Random rand = new Random();
int m = rand.Next(2, 5);
int n = rand.Next(2, 5);
int[,] matrix = new int[m, n];
int[,] swapmatrix = new int[n, m];

Console.Clear();
Console.WriteLine($"*************************************************");
Console.WriteLine($"Дан массив на {m} строк (-и) и {n} столбца (-ов)");
Console.WriteLine($"*************************************************");

FillArray(matrix);
PrintArray(matrix);

Console.WriteLine($"*************************************************");

RowsToColumns(matrix, swapmatrix);
PrintArray(swapmatrix);

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

void RowsToColumns (int[,] array, int[,] array2)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array2[j,i] = array[i, j];
        }
    }
}
