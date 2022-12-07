// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет



Console.WriteLine("Введите размер двумерного массива M x N");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(0, 11);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Введите координаты ячейки M х N");
Console.Write("Введите M : ");
int firstDot = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N : ");
int lastDot = Convert.ToInt32(Console.ReadLine());
if (firstDot  <= m && lastDot <= n)
{
    Console.WriteLine("результат ваших координат : " + matrix[firstDot-1, lastDot-1]);
}
else
{
    Console.WriteLine("нет таких ячеек ");
}
