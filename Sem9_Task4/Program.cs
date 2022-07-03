// Задача 67: Напишите программу, которая будет 
// принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Random rand = new Random();
int number = 1829546777;

Console.WriteLine("Сумма цифр числа равна " + Recursion(number));

int Recursion(int currentNumber, int sum = 0)
{
    if (currentNumber == 0)
    {
        //Console.WriteLine("Сумма цифр числа равна " + sum);
        return sum;
    }
    sum += currentNumber % 10;
    return Recursion(currentNumber/10, sum);
}