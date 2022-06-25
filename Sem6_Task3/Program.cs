// Перевод десятичного числа в двоичное
// Решаем через string и конкотинацию

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

TenToTwo(number);

void TenToTwo(int currentNumber)
{
    string result = "";
    int startNumber = currentNumber;
    while (currentNumber > 0)
    {
        result = currentNumber % 2 + result; //Конкотинация строк
        currentNumber = currentNumber / 2;
    }
    Console.WriteLine($"{startNumber} -> {result}");

}