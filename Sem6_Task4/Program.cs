// Вывести числа Фибоначчи, не используя рекурсию

double first = 0;
double second = 1;
double finish = 80;
Console.WriteLine("1. 0");
Console.WriteLine("2. 1");
for (int i = 3; i <= finish; i++)
{
    double nextNumber = first + second;
    Console.WriteLine($"{i}. {nextNumber}");
    first = second;
    second = nextNumber;
}
