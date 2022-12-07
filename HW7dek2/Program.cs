// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void PrintArray(double [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void FillArray( double [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Math.Round((Convert.ToDouble((new Random().Next(-100, 200)) + new Random().NextDouble())), 2);
        }

    }
}
Console.WriteLine("Введите количество cстолбцов : ");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк    : ");
int line = Convert.ToInt32(Console.ReadLine());
double [,] matrix = new double [column, line];
// PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine("END");