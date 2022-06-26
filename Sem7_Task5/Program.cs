// Дан двумерный массив из двух строк и двадцати двух столбцов. 
// В его первой строке записано количество мячей, забитых футбольной командой в той или иной игре, 
// во второй — количество пропущенных мячей в этой же игре.
// а) Для  каждой  проведенной  игры  напечатать  словесный  результат:  "выигрыш", "ничья" или "проигрыш". 
// б) Определить количество выигрышей данной команды. 
// в) Определить  количество  выигрышей  и  количество  проигрышей  данной   команды. 
// г) Определить количество выигрышей, количество ничьих и количество проигрышей данной команды. 
// д) Определить,  в  скольких  играх  разность  забитых  и  пропущенных  мячей  была большей или равной трем. 
// е) Определить общее число очков, набранных командой (за выигрыш даются 3 очка, за ничью — 1, за проигрыш — 0).

int rows = 2;
int columns = 10; //Уменьшаем для удобства во время решения
int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);
StringResult(array);

void FillArray(int[,] currentArray)
{
    Random rand = new Random();
    for (int i = 0; i < currentArray.GetLength(0); i++)
    {
        for (int j = 0; j < currentArray.GetLength(1); j++)
        {
            currentArray[i, j] = rand.Next(0, 10);
        }
    }
}

void PrintArray(int[,] currentArray)
{
    for (int i = 0; i < currentArray.GetLength(0); i++)
    {
        for (int j = 0; j < currentArray.GetLength(1); j++)
        {
            Console.Write(currentArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void StringResult(int[,] currentArray)
{
    for (int j = 0; j < currentArray.GetLength(1); j++)
    {
        Console.Write($"Игра {j + 1}. Результат: ");
        if (currentArray[0, j] > currentArray[1, j])
        {
            Console.Write("победа");
        }
        else if (currentArray[0, j] == currentArray[1, j])
        {
            Console.Write("ничья");
        }
        else if (currentArray[0, j] < currentArray[1, j])
        {
            Console.Write("поражение");
        }
        Console.WriteLine();
    }
}

