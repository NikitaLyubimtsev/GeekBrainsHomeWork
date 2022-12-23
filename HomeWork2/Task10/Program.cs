using static System.Console;
Clear();

Write("Введите любое трёхзначное число: ");
string num = ReadLine();
WriteLine(num.Length != 3 ? "Вы наверное ошиблись и ввели не трёхзначное число!" : (Convert.ToInt32(num)%100/10));