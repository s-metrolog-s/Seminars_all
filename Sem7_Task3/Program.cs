// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

Random rand = new Random();
int rows = rand.Next(2, 10);
int columns = rand.Next(2, 10);

int[,] array = new int[rows,columns];

FillArray(array);
PrintArray(array);
FindEvenNumber(array);
PrintArray(array);

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

void FindEvenNumber(int[,] currentArray)
{
    for (int i = 0; i < currentArray.GetLength(0); i++)
    {
        for (int j = 0; j < currentArray.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                currentArray[i, j] += currentArray[i, j];
            }
        }
        Console.WriteLine();
    }
}

