using static System.Console;

Write("Введите первое число: ");
int a = int.Parse(ReadLine()!);

Write("Введите второе число: ");
int b = int.Parse(ReadLine()!);

Write("Введите третье число: ");
int c = int.Parse(ReadLine()!);

int max = a;

if (b > max) {
    max = b;
} else if (c > max) {
    max = c;
}

Write($"Максимальным из введённых является число: {max}");