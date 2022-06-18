// Задача 28: Напишите программу, которая принимает на вход 
// число N и выдаёт произведение чисел от 1 до N.

Random rand = new Random();
int N = rand.Next(1, 10);

Console.WriteLine($"Дано случайное число: {N}");
Console.WriteLine("Считаем произведение");

void Check (int number)
{
int count = 1;
int result = 1;
while (count <= number)
{
    result = result * count;
    count++;
}
Console.WriteLine($"Произведение равно: {result}");
}

Check(N);