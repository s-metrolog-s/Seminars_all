// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: 
// A = m+n. Выведите полученный массив на экран.

Random rand = new Random();
int rows = rand.Next(2, 10);
int columns = rand.Next(2, 10);

int[,] array = new int[rows,columns];

FillArray(array);
PrintArray(array);

void FillArray(int[,] currentArray)
{
    for (int i = 0; i < currentArray.GetLength(0); i++)
    {
        for (int j = 0; j < currentArray.GetLength(1); j++)
        {
            currentArray[i, j] = i + j;
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

