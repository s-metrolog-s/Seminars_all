// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

int[] array = new int[10];

Console.Clear();
Console.WriteLine("************************************************************");
Console.WriteLine("Дан массив случайных чисел:");

MakeArray(array);
PrintArray(array);

Console.WriteLine("Массив в обратном порядке:");

BackArray(array);
PrintArray(array);

void MakeArray(int[] currentArray)
{
    Random rand = new Random();
    for (int i = 0; i < currentArray.Length; i++)
    {
        currentArray[i] = rand.Next(1, 10);
    }
}

void PrintArray(int[] currentArray)
{
    for (int i = 0; i < currentArray.Length; i++)
    {
        Console.Write($"{currentArray[i]} \t");
    }
    Console.WriteLine("");
}

void BackArray(int[] currentArray)
{
    int lastIndex = currentArray.Length - 1;
    for (int i = 0; i < currentArray.Length / 2; i++)
    {
        int temp = currentArray[i];
        currentArray[i] = currentArray[lastIndex];
        currentArray[lastIndex] = temp;
        lastIndex--;
    }
}

Console.WriteLine("************************************************************");