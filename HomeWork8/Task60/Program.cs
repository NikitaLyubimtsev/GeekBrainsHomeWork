// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
using static System.Console;
Clear();

int[,,] tripMatrix = GetMatrix(AskToUserSizeMatrix());

for (int i = 0; i < tripMatrix.GetLength(0); i++)
{
    for (int j = 0; j < tripMatrix.GetLength(1); j++)
    {
        for (int n = 0; n < tripMatrix.GetLength(2); n++)
        {
            WriteLine($"{tripMatrix[i,j,n]}({i},{j},{n})");
        }
    }
}

void FillMatrix(int[,,] mtrx)
{
    List<int> elOfMtrx = new List<int>();
    for (int i = 0; i < mtrx.GetLength(0); i++) {
        for (int j = 0; j < mtrx.GetLength(1); j++) {
            for (int z = 0; z < mtrx.GetLength(2); z++)
            {
                int el = new Random().Next(10, 99);
                while (elOfMtrx.Contains(el))
                {
                    el = new Random().Next(10, 99);
                }
                elOfMtrx.Add(el);
                mtrx[i, j, z] = el;
            }
        }
    }
}

int[,,] GetMatrix(SizeMatrix size)
{
    int[,,] matrix = new int[size.x, size.y, size.z];
    FillMatrix(matrix);
    return matrix;
}

SizeMatrix AskToUserSizeMatrix()
{
    SizeMatrix size = new SizeMatrix();
    Write("Введите размеры создаваемого трёхмерного массива через знак ','. Сначала число строк потом число столбцов затем глубину: ");
    string[] inputOfArray = ReadLine()!.Split(",", StringSplitOptions.RemoveEmptyEntries);

    if (int.TryParse(inputOfArray[0], out int x) &
        int.TryParse(inputOfArray[1], out int y) &
        int.TryParse(inputOfArray[2], out int z)
        )
        {
            size.x = x;
            size.y = y;
            size.z = z;
        } else {
            WriteLine("Ошибка ввода!");
            Environment.Exit(1);
        }
    return size;
}

struct SizeMatrix
{
    public int x;
    public int y;
    public int z;
}