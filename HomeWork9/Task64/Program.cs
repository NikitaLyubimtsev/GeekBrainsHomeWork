// Напишите программу, которая реализует рекурсивный метод вывода всех натуральных чисел в промежутке от N до 1.
using static System.Console;
Clear();

WriteLine(GetNumbers(AskUserToN()));

int AskUserToN()
{
    Write("Введите число N от которого необходимо построить ряд натуральных чисел (N ... 1): ");
    if (int.TryParse(ReadLine(), out int num)){}
    else
    {
        Write("Введено не число!");
        Environment.Exit(1);
    }
    return num;
}

string GetNumbers(int num)
{
    return (num == 1) ? num.ToString() : $"{num},{GetNumbers(num - 1)}";
}