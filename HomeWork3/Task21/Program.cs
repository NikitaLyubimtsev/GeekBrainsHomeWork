using static System.Console;
Clear();

WriteLine("Введите координаты точки А");
Write("x: ");
if (!int.TryParse(ReadLine(), out int ax)) {
    Write("Ошибка!");
    return;
}
Write("y: ");
if (!int.TryParse(ReadLine(), out int ay)) {
    Write("Ошибка!");
    return;
}
Write("z: ");
if (!int.TryParse(ReadLine(), out int az)) {
    Write("Ошибка!");
    return;
}
WriteLine("Введите координаты точки B");
Write("x: ");
if (!int.TryParse(ReadLine(), out int bx)) {
    Write("Ошибка!");
    return;
}
Write("y: ");
if (!int.TryParse(ReadLine(), out int by)) {
    Write("Ошибка!");
    return;
}
Write("z: ");
if (!int.TryParse(ReadLine(), out int bz)) {
    Write("Ошибка!");
    return;
}

double result = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
WriteLine($"{result:f2}");
