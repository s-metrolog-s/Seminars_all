// Задача 24: Напишите программу, которая принимает на вход 
// число (А) и выдаёт сумму чисел от 1 до А.

Random rand = new Random();
int A = 100; //rand.Next(2, 10);
Console.WriteLine("");

void Fact (int currentNumber)
{
int sum = 0;
int count = 1;
while (count <= currentNumber)
{
    sum += count;
    count++;
}
Console.WriteLine("Сумма равна: " + sum);
}

Fact(A);