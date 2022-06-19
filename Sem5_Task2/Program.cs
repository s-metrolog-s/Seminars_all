// Задача 32: Напишите программу замены элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 
Console.Clear();
Console.WriteLine("Дан следующий массив:");

int[] array = new int[10];

MakeArray(array);
PrintArray(array);

Console.WriteLine("Записываем отрицательный вариант:");
MinusMass(array);
PrintArray(array);

void MakeArray(int[] mainArray)
{
    Random rand = new Random();
    for (int i = 0; i < mainArray.Length; i++)
    {
        mainArray[i] = rand.Next(-9, 10);
    }
}

void PrintArray(int[] currentArray)
{
    Console.WriteLine();
    for (int i = 0; i < currentArray.Length; i++)
    {
        Console.Write(currentArray[i] + "\t");
    }
    Console.WriteLine();
}

void MinusMass(int[] currentArray)
{
    for (int i = 0; i < currentArray.Length; i++)
    {
        currentArray[i] = currentArray[i] * - 1;
    }
}