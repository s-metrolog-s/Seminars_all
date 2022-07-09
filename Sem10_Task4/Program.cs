// Задача 72: Заданы 2 массива: info и data. 
// В массиве info хранятся двоичные представления нескольких чисел (без разделителя). 
// В массиве data хранится информация о количестве бит, которые занимают числа из массива info. 
// Напишите программу, которая составит массив десятичных представлений чисел 
// массива data с учётом информации из массива info.

int[] data = {0, 1, 1, 1, 1, 0, 0, 0, 1};
int[] info = {2, 3, 3, 1};

int secondIndex = 0;
for (int i = 0; i < info.Length; i++)
{
    int size = info[i];
    int power = size - 1;
    double result = 0;
    for (int j = secondIndex; j < size + secondIndex; j++)
    {
        result += data[j] * Math.Pow(2, power);
        power--;
    }
    secondIndex += size;
    Console.WriteLine($"{i + 1} число равно {result}");
}