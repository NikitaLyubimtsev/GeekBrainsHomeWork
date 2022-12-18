using static System.Console;

WriteLine("Введите два числа: ");

int a = int.Parse(ReadLine()!);
int b = int.Parse(ReadLine()!);
int max = a;
int min = a;

if (b > max) {
    max = b;
} else {
    min = b;
}

WriteLine($"Максимальное, из введённых чисел: {max}, минимальное {min}.");