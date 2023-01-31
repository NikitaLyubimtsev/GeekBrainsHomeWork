// Напишите программу реализующую метод вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
using static System.Console;
Clear();
WriteLine(A(2,3));

uint A(uint n, uint m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if ((n != 0) && (m == 0))
    {
        return A(n -1, 1);
    }
    else
    {
        return A(n - 1, A(n, m - 1));
    }
}