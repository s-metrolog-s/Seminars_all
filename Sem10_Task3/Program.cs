// Задача 71: В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
// Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита.
// n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са, 
// ав, ва, ви, ив, св, вс

string alphabet = "аисв";
int count = 3;

Recursion(alphabet, count);

void Recursion(string alphebet, int count, string result = "")
{
    if (count == 0)
    {
        Console.WriteLine(result);
        return;
    }

    for (int i = 0; i < alphebet.Length; i++)
    {
        Recursion(alphabet, count - 1, result + alphabet[i]);
    }
}