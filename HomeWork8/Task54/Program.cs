// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
using static System.Console;
Clear();

int[,] matrix = GetMatrix(AskToUserSizeMatrix());
PrintMatrix(matrix);
SortRowOfMatrix(matrix);
WriteLine();
PrintMatrix(matrix);

void SortRowOfMatrix(int[,] mtrx)
{
    for (int row = 0; row < mtrx.GetLength(0); row++)
    {
        for (int col = 1; col < mtrx.GetLength(1); col++)
        {
            int elementToInsert = mtrx[row, col];
            int preCol = col - 1;           
            while (preCol >= 0)
            {
                if (elementToInsert > mtrx[row, preCol])
                {
                    mtrx[row, preCol + 1] = mtrx[row, preCol];
                } else {
                    break;
                }
                preCol--;
            }
            mtrx[row, preCol + 1] = elementToInsert;
        }
    }
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
            arr[i,j] = new Random().Next(1, 20);
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
    Write("Введите размеры создаваемой двухмерной матрицы через знак ','. Сначала число строк потом число столбцов: ");
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
