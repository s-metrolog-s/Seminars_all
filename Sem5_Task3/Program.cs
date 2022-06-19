// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

Console.Clear();
Console.WriteLine("Дан следующий массив:");

int[] array = new int[10];

MakeArray(array);
PrintArray(array);

Console.WriteLine("Введите число, которое необходимо найти:");
int N = Convert.ToInt32(Console.ReadLine());

Find(array, N);

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

void Find(int[] currentArray, int Value)
{
    bool flag = false;
    for (int i = 0; i < currentArray.Length; i++)
    {
        if (currentArray[i] == Value)
        {
            flag = true;
            break;
        }
    }
    if (flag) Console.WriteLine($"Значение {Value} в массиве найдено");
    else Console.WriteLine($"Значение {Value} отсутствует");
}

Console.WriteLine("************************************");