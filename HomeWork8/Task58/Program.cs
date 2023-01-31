// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
using static System.Console;
Clear();

int[,] matrixA = GetMatrix(AskToUserSizeMatrix());
int[,] matrixB = GetMatrix(AskToUserSizeMatrix());
PrintMatrix(matrixA);
WriteLine();
PrintMatrix(matrixB);
WriteLine("---------");

PrintMatrix(ProductOfMatrix(matrixA, matrixB));

int[,] ProductOfMatrix(int[,] mtrxOne, int[,] mtrxTwo)
{
    if (mtrxOne.GetLength(1) != mtrxTwo.GetLength(0)) {
        WriteLine("Такие матрицы нельзя перемножать!");
        Environment.Exit(1);
    }
    int[,] resMtrx = new int[mtrxOne.GetLength(0), mtrxTwo.GetLength(1)];

    for (int i = 0; i < mtrxOne.GetLength(0); i++)
    {
        for (int j = 0; j < mtrxTwo.GetLength(1); j++)
        {
            int newEl = 0;
            for (int n = 0; n < mtrxTwo.GetLength(0); n++)
            {
                newEl += mtrxOne[i, n] * mtrxTwo[n, j];
            }
            resMtrx[i, j] = newEl;
        }
    }
    return resMtrx;
}

// Реализация стандартных методов
void PrintMatrix(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++) {
        for(int j = 0; j < arr.GetLength(1); j++) {
        Write($"{arr[i,j]} ");
        }
        WriteLine();
    }
}

int[,] FillMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            arr[i,j] = new Random().Next(1, 10);
        }
    }
    return arr;
}

int[,] GetMatrix(SizeMatrix size)
{
    int[,] matrix = new int[size.rows, size.column];
    FillMatrix(matrix);
    return matrix;
}

SizeMatrix AskToUserSizeMatrix()
{
    SizeMatrix size = new SizeMatrix();
    Write("Введите размеры создаваемого прямоугольного массива через знак ','. Сначала число строк потом число столбцов: ");
    string[] inputOfArray = ReadLine()!.Split(",", StringSplitOptions.RemoveEmptyEntries);

    if (int.TryParse(inputOfArray[0], out int rows) &
        int.TryParse(inputOfArray[1], out int column)
        )
        {
            size.rows = rows;
            size.column = column;
        } else {
            WriteLine("Ошибка ввода!");
            Environment.Exit(1);
        }
    return size;
}

struct SizeMatrix
{
    public int rows;
    public int column;
}