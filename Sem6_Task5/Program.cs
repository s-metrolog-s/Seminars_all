// Копия заданного массива с помощью поэлементного копирования

int[] A = new int[8] { 5, 8, 9, 10, -5, 0, -3, 1 };
int[] B = new int[A.Length];

for (int i = 0; i < A.Length; i++)
{
    B[i] = A[i];
}

for (int i = 0; i < A.Length; i++)
{
    Console.Write($"{B[i]} \t");
}