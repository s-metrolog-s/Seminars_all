// Задача 31: Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.

/* Тестирование функций на семинаре
int number = 5; 
PrintNumber(number);

Console.WriteLine("Квадрат числа: " + ReturnNumber(number));
Console.WriteLine(ReturnNumber(number) + ReturnNumber(number));

void PrintNumber(int number)
{
    Console.WriteLine("Введено число: " + number);
}

int ReturnNumber(int number)
{
    return number * number;
}
*/

int[] array = new int[12];
SetArray(array);
PrintArray(array);
Zadacha31(array);

array = SetArrayFunc(array.Length);
PrintArray(array);
Zadacha31(array);

void SetArray(int[] currentArray)
{
    Random rand = new Random();
    for (int i = 0; i < currentArray.Length; i++)
    {
        currentArray[i] = rand.Next(-9, 10);
    }
}

int[] SetArrayFunc(int size)
{
    int[] newArray = new int[size];
    Random rand = new Random();
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rand.Next(-9, 10);
    }
    return newArray;
}

void PrintArray(int[] currentArray)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива на печать:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(currentArray[i] + "\t");
    }
    Console.WriteLine();
}

void Zadacha31(int[] currentArray)
{
    Console.WriteLine();
    Console.WriteLine("начинается подсчет сумм...");
    int sumPos = 0;
    int sumNeg = 0;
    for (int i = 0; i < currentArray.Length; i++)
    {
        if (currentArray[i] > 0) sumPos += currentArray[i];
        else sumNeg += currentArray[i];
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма позитивных элементов {sumPos}");
    Console.WriteLine($"Сумма негативных элементов {sumNeg}");
}

