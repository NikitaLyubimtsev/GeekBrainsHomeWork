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
Write("Введите число которое необходимо возвести в степень: ");
if (int.TryParse(ReadLine(), out int a)) {
    Write("Введите степень в которую необходимо возвести число: ");
    if (int.TryParse(ReadLine(), out int b)) WriteLine(DegreeOfNumber(a, b));
    else Write("Ошибка ввода, возможно вывели не число!");
} else Write("Ошибка ввода, возможно вывели не число!");

