// Напишите программу, реализующую метод, который принимает на вход число и выдаёт сумму цифр в числе.

using static System.Console;
Clear();

int SumDigitsNumber(int num)
{
    int sum = 0;
    for (int n = num; n > 0; n /= 10 ) {
        sum += n % 10;
    }
    return sum;
}

Write("Введите любое число, что бы получить сумму его цифр: ");
if (int.TryParse(ReadLine(), out int num)) WriteLine(SumDigitsNumber(num));
else Write("Ошибка ввода, возможно вывели не число!");