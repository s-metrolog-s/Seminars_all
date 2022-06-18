// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

Random rand = new Random();
int N = rand.Next(100, 10000);

Console.WriteLine($"Дано случайно число: {N}");
Console.WriteLine("Считаем количество цифр");

void Check (int number)
{
int count = 0;
while (number > 0)
{
    number = number / 10;
    count++;
}
Console.WriteLine($"Количество цифр в числе равно: {count}");
}

Check(N);