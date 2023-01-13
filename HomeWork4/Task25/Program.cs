//  Напишите программу, реализующую метод,который принимает на вход два числа (A и B) и возводит число A в натуральную степень B с использованием цикла.


using static System.Console;
Clear();

int DegreeOfNumber(int a, int b)
{
    int res = a;
    for (int i = 0; i < (b - 1); i++) {

        res = res * a;
    }
    return res;
}
WriteLine(DegreeOfNumber(3, 5));
