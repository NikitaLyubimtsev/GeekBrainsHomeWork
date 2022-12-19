using static System.Console;

Write("Введите любое число: ");
 int a = int.Parse(ReadLine()!);

 if (a % 2 == 0) {
    WriteLine("Да");
 } else {
    WriteLine("Нет");
 }
