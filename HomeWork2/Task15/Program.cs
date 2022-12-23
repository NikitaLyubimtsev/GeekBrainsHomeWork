using static System.Console;
Clear();

Write("Введите любое число обозначающее день недели (от 1 до 7): ");
int num = Convert.ToInt16(ReadLine());
WriteLine(num > 7 ? $"Цифра {num} не обозначение не один из дней недели!" : num < 6 ? "Нет" : "Да");