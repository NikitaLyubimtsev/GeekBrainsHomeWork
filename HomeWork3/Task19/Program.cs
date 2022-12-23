using static System.Console;
Clear();

Write("Введите любое пятизначное число: ");
int num = Convert.ToInt32(ReadLine());
WriteLine(num < 9999 ? "Вы ввели не пятизначное число!" : ((num % 10) == (num / 10000) && (num % 100 / 10) == (num / 1000 % 10)) ? "Да" : "Нет");
