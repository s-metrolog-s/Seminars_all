// Задача 58: Заполните спирально массив 4 на 4 числами от 1 до 16.

int rows = 4;
int columns = 4;
int[,] matrix = new int[rows, columns];

Console.Clear();
Console.WriteLine("*************************************************");
Console.WriteLine($"Дан массив на {rows} и {columns} стролбцов");
Console.WriteLine("*************************************************");

Console.WriteLine("Заполняем массив змейкой");
//FillArraySnake(matrix);
//PrintArray(matrix);

Console.WriteLine("*************************************************");

Console.WriteLine("Заполняем массив по спирали");
FillArraySpiral(matrix);
PrintArray(matrix);

void FillArraySnake (int[,] currentArray)

{
    int count = 1;
    for (int i = 0; i < currentArray.GetLength(0); i++)
    {
        if (i % 2 == 0)
        {
            for (int j = 0; j < currentArray.GetLength(1); j++)
            {
                currentArray[i, j] = count++;
            }
        }
        else
        {
            for (int j = currentArray.GetLength(1) - 1; j >= 0; j--)
            {
                currentArray[i, j] = count++;
            }
        }
    }
}

void FillArraySpiral(int[,] currentArray)
{
    int sizeX = 4;
    int sizeY = 4;
    int indexX = 0;
    int indexY = 0;

    int changeX = 0;
    int changeY = 1;

    int steps = sizeY;
    int rotate = 0;

    for (int i = 0; i < currentArray.Length; i++)
    {
        currentArray[indexX, indexY] = i + 1;
        steps--;
        if (steps == 0)
        {
            steps = sizeY * ((rotate)%2) + sizeX * ((rotate+1)%2) - 1 - rotate/2;
            // Получается одна из двух формул
            int temp = changeX;
            changeX = changeY;
            changeY = -temp;
            rotate++;
        }
        indexX += changeX;
        indexY += changeY;
    }
}

void PrintArray (int[,] currentArray)
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