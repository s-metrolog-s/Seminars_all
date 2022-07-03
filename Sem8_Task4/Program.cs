// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.


Random rand = new Random();
int rows = rand.Next(4, 7);
int columns = rand.Next(4, 7);
int[,] matrix = new int[rows, columns];
int[,] matrixSecond = new int[rows-1, columns-1];

Console.Clear();
Console.WriteLine($"*************************************************");
Console.WriteLine($"Дан массив на {rows} строк (-и) и {columns} столбца (-ов)");
Console.WriteLine($"*************************************************");

FillArray(matrix, -99, 100);
PrintArray(matrix);

Console.WriteLine($"*************************************************");

int min = matrix[0, 0];
int indexMinRow = 0;
int indexMinColumn = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] < min) 
        {
        min = matrix[i, j];
        indexMinRow = i;
        indexMinColumn = j;
        }
    }
}

int biasI = 0;
for (int i = 0; i < matrixSecond.GetLength(0); i++)
{
    if (i == indexMinRow) biasI = 1;
    int biasJ = 0;
    for (int j = 0; j < matrixSecond.GetLength(1); j++)
    {
        if (j == indexMinColumn) biasJ = 1;
        matrixSecond[i, j] = matrix[i + biasI, j + biasJ];
    }
}
Console.WriteLine($"Минимальный элемент {min}");
Console.WriteLine($"его строка {indexMinRow + 1}, его столбец {indexMinColumn + 1}");
PrintArray(matrixSecond);
Console.WriteLine($"*************************************************");

void FillArray (int[,] array, int min = 0, int max = 10)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(min, max);
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

/*
void FindNumber (int[,] array)
{
    IndexMinRow = 0;
    IndexMinColumn = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

        }
    }
}
*/