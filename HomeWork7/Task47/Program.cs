// Напишите программу реализующую метод, который возвращает массив размером m×n, заполненный случайными вещественными числами.
using static System.Console;
Clear();

double RandomRealNumber()
{
    int min = 1;
    int max = 100;
    int range = max - min;
    double rand_n = new Random().NextDouble();
    return Math.Round((rand_n * range) + min, 1);
}

void PrintArray(double[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++) {
        for(int j = 0; j < arr.GetLength(1); j++) {
        Write($"{arr[i,j]} ");
        }
        WriteLine();
    }
}

void FillArray(double[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++) {
        for(int j = 0; j < matr.GetLength(1); j++) {
        matr[i,j] = RandomRealNumber();
        }
    }
}

double[,] GetMatrix(int m, int n)
{
    double[,] matrix = new double[m, n];
    FillArray(matrix);
    return matrix;
}

PrintArray(GetMatrix(4,8));