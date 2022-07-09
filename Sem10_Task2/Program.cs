// Задача 70: Напишите программу, которая на вход 
// принимает два числа и выдаёт первые N чисел, для которых 
// каждое следующее равно сумме двух предыдущих.

Random rand = new Random();
int firstNumber = rand.Next(1, 10);
int secondNumber = firstNumber + rand.Next(1, 10);
int count = rand.Next(1, 10);

Console.WriteLine($"Вывести первые {count} чисел для элементов {firstNumber} и {secondNumber}");
Recursion(firstNumber, secondNumber, count);

void Recursion(int startNumber, int finishNumber, int count)
{
    if (count == 0) return;
    Console.Write(startNumber + "\t");
    finishNumber = startNumber + finishNumber;
    startNumber = finishNumber - startNumber;

    Recursion(startNumber, finishNumber, count - 1);

    // Кортеж
    //(startNumber, finishNumber) = (finishNumber, startNumber + finishNumber);
}