// Напишите программу, которая реализует рекурсивный метод нахождения суммы натуральных элементов в промежутке от M до N.
using static System.Console;
Clear();


WriteLine(SumToNumbers(1, 5));

int SumToNumbers(int begin, int end)
{
    return (begin == end) ? begin : begin + SumToNumbers(begin + 1, end);
}