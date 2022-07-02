// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.

Random rand = new Random();
int m = rand.Next(2, 5);
int n = rand.Next(2, 5);
int[,] matrix = new int[m, n];
int[] dictionary = new int[10];

Console.Clear();
Console.WriteLine($"*************************************************");
Console.WriteLine($"Дан массив на {m} строк (-и) и {n} столбца (-ов)");
Console.WriteLine($"*************************************************");

FillArray(matrix);
PrintArray(matrix);

Console.WriteLine($"*************************************************");

MakeDictionary(matrix);

for (int i = 0; i < dictionary.Length; i++)
{
    if (dictionary[i] != 0) Console.WriteLine($"{i} встречается {dictionary[i]} раз");
}

Console.WriteLine($"*************************************************");

void FillArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(0, 10);
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

void MakeDictionary (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            dictionary[array[i, j]]++;
        }

    }
}
