// Задача 30: Напишите программу, которая 
// выводит массив из 8 элементов, заполненный нулями 
// и единицами в случайном порядке.

Random rand = new Random();
int[] array = new int[8];

void RandMassFill ()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0, 2);
    }
}

void RandMassPrint ()
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

RandMassFill();
RandMassPrint();