// Задача 69: Напишите программу, которая на вход 
// принимает два числа A и B, и возводит 
// число А в целую степень B с помощью рекурсии.

int number = 5;
int power = 3;

Console.WriteLine($"Число {number} в степени {power} равно  " + Recursion2(number, power));

int Recursion(int currentNumber, int currentPower, int result = 1)
{
    if (currentPower == 0) return result;
    result *= currentNumber;
    return Recursion(currentNumber, currentPower - 1, result);
}

int Recursion2(int currentNumber, int currentPower)
{
    if (currentPower == 0) return 1;
    // result *= currentNumber;
    return currentNumber * Recursion2(currentNumber, currentPower - 1);
}