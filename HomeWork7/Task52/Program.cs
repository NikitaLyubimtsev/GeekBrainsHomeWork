// Напишите программу реализующую методы, формирования двумерного массива и массива средних арифметических значений каждого столбца.
using static System.Console;
Clear();

SizeArray size = AskToUserSizeArray();
int[,] matrix = GetMatrix(size);
PrintMatrix(matrix);
Write(String.Join("; ", GetAvgColumn(matrix)));

double[] GetAvgColumn(int[,] mtrx)
{
    double[] avgColumn = new double[mtrx.GetLength(1)];
    for (int c = 0; c < mtrx.GetLength(1); c++) {
        int sum = 0;
        for (int r = 0; r < mtrx.GetLength(0); r++)
        {
            sum += mtrx[r,c];
        }
        avgColumn[c] = Math.Round(Convert.ToDouble(sum) / Convert.ToDouble(mtrx.GetLength(0)), 1);
    }
    return avgColumn;
}

SizeArray AskToUserSizeArray()
{
    SizeArray size = new SizeArray();
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

int[,] FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            arr[i,j] = new Random().Next(1, 20);
        }
    }
    return arr;
}

int[,] GetMatrix(SizeArray size)
{
    int[,] matrix = new int[size.rows, size.column];
    FillArray(matrix);
    return matrix;
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

struct SizeArray
{
    public int rows;
    public int column;
}