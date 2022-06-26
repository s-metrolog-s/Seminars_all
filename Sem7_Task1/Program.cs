// Задать двумерный массив, заполенный случайными числами.

Random rand = new Random();
int rows = rand.Next(2, 10);
int columns = rand.Next(2, 10);

int[,] array = new int[rows,columns];

Console.WriteLine("Количество строк" + " " + array.GetLength(0));
Console.WriteLine("Количество столбцов" + " " + array.GetLength(1));

FillArray(array);
PrintArray(array);

void FillArray(int[,] currentArray)
{
    for (int i = 0; i < currentArray.GetLength(0); i++)
    {
        for (int j = 0; j < currentArray.GetLength(1); j++)
        {
            currentArray[i, j] = rand.Next(-50, 51);
        }
    }
}

void PrintArray(int[,] currentArray)
{
    for (int i = 0; i < currentArray.GetLength(0); i++)
    {
        for (int j = 0; j < currentArray.GetLength(1); j++)
        {
            Console.Write(currentArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


