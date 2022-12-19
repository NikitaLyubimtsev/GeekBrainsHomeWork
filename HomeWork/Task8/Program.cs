using static System.Console;

Write("Введите любое число: ");
int n = int.Parse(ReadLine()!);

int count = 0;

if (n > 1 || n % 2 != 0) {
   n++;
}

while ((n - 2) > count) {
    count += 2;
    if (count == (n - 1) || count == (n - 2)) {
        Write(count);
    } else {
        Write($"{count}, ");
    }
}
