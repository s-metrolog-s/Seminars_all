// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5

int[] array = new int[10];
int count = 0;

MakeArray(array, 0, 150);
PrintArray(array);

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 9 && array[i] < 100) count++;
}
Console.WriteLine(count);

void MakeArray(int[] mainArray, int start, int end)
{
    Random rand = new Random();
    end++;
    for (int i = 0; i < mainArray.Length; i++)
    {
        mainArray[i] = rand.Next(start, end);
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