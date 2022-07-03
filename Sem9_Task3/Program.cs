// Задача 65: Задайте значения M и N. 
// Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.

Random rand = new Random();
int N = rand.Next(1, 20);
int M = rand.Next(1, 20);

Console.WriteLine($"Даны числа M: {M} и N: {N}");
if (N > M) Recursion(M, N);

void Recursion(int number1, int number2)
{
    if (number1 > number2) return;
    Console.WriteLine(number1);
    Recursion(number1 + 1, number2);
}