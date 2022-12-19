using static System.Console;

Write("Введите первое число: ");
int a = int.Parse(ReadLine()!);

Write("Введите второе число: ");
int b = int.Parse(ReadLine()!);

int max = a;
int min = a;

if (b > max) {
    max = b;
} else {
    min = b;
}

WriteLine($"Максимальное, из введённых чисел: {max}, минимальное {min}.");