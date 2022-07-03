// Задача 63. Вывести все натуральные числа от 1 до N
// Используем рекурсиию

int number = 8; // 8 7 6 5 4 3 2 1

Recursion(number);

void Recursion(int currentNumber, int count = 1)
{
    if (count > currentNumber) return;
    Console.WriteLine(count);
    Recursion(currentNumber, count + 1);
}
