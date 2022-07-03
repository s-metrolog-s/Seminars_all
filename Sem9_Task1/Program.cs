// 

Random rand = new Random();
int rowsA = rand.Next(3, 6);
int columnsA = rand.Next(3, 5);
int rowsB = columnsA;
int columnsB = rand.Next(3, 5);
int[,] matrixA = new int[rowsA, columnsA];
int[,] matrixB = new int[rowsB, columnsB];
int[,] matrixC = new int[rowsA, columnsB];

Console.Clear();
Console.WriteLine($"*************************************************");

FillArray(matrixA);
PrintArray(matrixA);
Console.WriteLine();
FillArray(matrixB);
PrintArray(matrixB);
Console.WriteLine();

for (int i = 0; i < matrixA.GetLength(0); i++)
{
    for (int j = 0; j < matrixB.GetLength(1); j++)
    {
        int sum = 0;
        for (int k = 0; k < matrixA.GetLength(1); k++)
        {
            sum += matrixA[i, k] * matrixB[k, j];
        }
        matrixC[i, j] = sum;
    }
}

PrintArray(matrixC);

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

void MatrixMult (int[,] matrixC, int[,] matrixA, int[,] matrixB)
{
for (int i = 0; i < matrixA.GetLength(0); i++)
{
    for (int j = 0; j < matrixB.GetLength(1); j++)
    {
        int sum = 0;
        for (int k = 0; k < matrixA.GetLength(1); k++)
        {
            sum += matrixA[i, k] * matrixB[k, j];
        }
        matrixC[i, j] = sum;
    }
}
}