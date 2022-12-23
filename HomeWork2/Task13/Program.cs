using static System.Console;
Clear();

Write("Введите любое число: ");
int num = Convert.ToInt32(ReadLine());
WriteLine(num > 999 ? num / 100 % 10 : num < 99 ? "Третей цифры нет!" : num / 100);