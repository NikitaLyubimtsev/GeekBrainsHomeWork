// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
using static System.Console;
Clear();
int[,] matrix = GetMatrix(AskToUserSizeMatrix());
PrintMatrix(matrix);
WriteLine("Строка с наименьшей суммой элементов - " + RowOfMaxElementSum(matrix));

int RowOfMaxElementSum(int[,] mtrx)
{
    int rowOfMinSum = 0;
    int minSumElementOfRow = 0;
    for (int row = rowOfMinSum; row < mtrx.GetLength(0); row++)
    {
        int sumElementOfRow = 0;
        for (int col = 0; col < mtrx.GetLength(1); col++)
        {
            sumElementOfRow += mtrx[row, col];
        }
        if (row == 0)
        {
            minSumElementOfRow = sumElementOfRow;
            rowOfMinSum = row + 1;
        }
        else
        {
            if (sumElementOfRow < minSumElementOfRow) {
                minSumElementOfRow = sumElementOfRow;
                rowOfMinSum = row + 1;
            }
        }
    }
    return rowOfMinSum;
}

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
            arr[i,j] = new Random().Next(1, 100);
        }
    }
    return arr;
}

int[,] GetMatrix(SizeMatrix size)
{
    int[,] matrix = new int[size.rows, size.column];
    if (size.column == size.rows)
    {
        WriteLine("Ошибка ввода!");
    }
    else
    {
        FillMatrix(matrix);
    }
    return matrix;
}

SizeMatrix AskToUserSizeMatrix()
{
    SizeMatrix size = new SizeMatrix();
    Write("Введите размеры создаваемого массива через знак ','. Стначала число строк потом число столбцов: ");
    string[] inputOfArray = ReadLine()!.Split(",", StringSplitOptions.RemoveEmptyEntries);

    if (int.TryParse(inputOfArray[0], out int rows) &
        int.TryParse(inputOfArray[1], out int column)
        )
        {
            size.rows = rows;
            size.column = column;
        }
    return size;
}

struct SizeMatrix
{
    public int rows;
    public int column;
}