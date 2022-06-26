// Задача 51: Задайте двумерный массив. Найдите сумму 
// элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

Random rand = new Random();
int rows = rand.Next(2, 10);
int columns = rand.Next(2, 10);

int[,] array = new int[rows,columns];

FillArray(array);
PrintArray(array);
Console.WriteLine($"Сумма элементов главной диагонали равна: {SumMainLine(array)}");


void FillArray(int[,] currentArray)
{
    for (int i = 0; i < currentArray.GetLength(0); i++)
    {
        for (int j = 0; j < currentArray.GetLength(1); j++)
        {
            currentArray[i, j] = rand.Next(1, 10);
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

int SumMainLine(int[,] currentArray)
{
    int sum = 0;
    for (int i = 0; i < currentArray.GetLength(0); i++)
    {
        for (int j = 0; j < currentArray.GetLength(1); j++)
        {
            if (i == j)
            {
                sum = sum + currentArray[i, j];
            }
        }
    }
    return sum;
}
