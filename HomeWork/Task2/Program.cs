using static System.Console;

WriteLine("Введите два числа: ");
int a = int.Parse(ReadLine()!);

int b = int.Parse(ReadLine()!);
int max = a;

if (b > max) {
    max = b;
}

WriteLine($"Максимальное, из введённых чисел: {max}");