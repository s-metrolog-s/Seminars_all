//Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 12 10

int[] array = new int[9];

MakeArray(array, 0, 150);
PrintArray(array);
int iteration = array.Length / 2;
int lastIndex = array.Length - 1;
for (int i = 0; i < iteration; i++)
{
    Console.Write($"{array[i]} * {array[lastIndex - i]} = ");
    Console.WriteLine($"{array[i] * array[lastIndex - i]}");
}
if (array.Length % 2 == 1) Console.WriteLine(array[iteration]);

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