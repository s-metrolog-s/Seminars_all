// ДЗ

string number1 = "4653";
Zadacha13(number1);
string number2 = "3458";
Zadacha13(number2);
string number3 = "38634829";
Zadacha13(number3);

void Zadacha13(string currentNumber)
{
    if (currentNumber.Length < 3)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        Console.WriteLine("Третья цифра: " + currentNumber[2]);
    }
}