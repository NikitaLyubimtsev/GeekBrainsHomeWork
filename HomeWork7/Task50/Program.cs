// Напишите программу реализующую метод,принимающий позиции элемента в двумерном массиве, и возвращающий значение этого элемента или же указание, что такого элемента нет.
using static System.Console;
Clear();

// Массив для проверки
int[,] matrix = new int[5,6];
PrintArray(FillArray(matrix));

int[,] FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            arr[i,j] = new Random().Next(1, 500);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++) {
        for(int j = 0; j < arr.GetLength(1); j++) {
        Write($"{arr[i,j]} ");
        }
        WriteLine();
    }
}

// Реализация методов
PositionOfElement pos = AskToUserPosisition();
FindElementOfMatrix(matrix, pos);

PositionOfElement AskToUserPosisition()
{
    PositionOfElement position = new PositionOfElement();
    Write("Введите позиции искомго элемента в матрице, с ипользованием разделителя ';'. Сначала номер строки затем номер колонки: ");
    string[] inputOfArray = ReadLine()!.Split(";", StringSplitOptions.RemoveEmptyEntries);

    if (int.TryParse(inputOfArray[0], out int rows) &
        int.TryParse(inputOfArray[1], out int column)
        )
        {
            position.rows = rows;
            position.column = column;
        }
    return position;
}


void FindElementOfMatrix(int[,] mtrx, PositionOfElement position)
{
    if ((mtrx.GetLength(0) > position.rows)
        & (mtrx.GetLength(1) > position.column)
    ) {
        Write(mtrx[position.rows, position.column]);
    } else {
        Write("такого элемента в массиве нет");
    }
}

struct PositionOfElement
{
    public int rows;
    public int column;
}