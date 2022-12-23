using static System.Console;
Clear();

Write("Введите любое число: ");
if (int.TryParse(ReadLine(), out int n)) {
    int num = 1;
    while (num <= n) {
        Write(num == n ? Math.Pow(num, 3) : $"{Math.Pow(num, 3)}, ");
        num++;
    } 
} else {
    WriteLine("Ошибка ввода!");
}