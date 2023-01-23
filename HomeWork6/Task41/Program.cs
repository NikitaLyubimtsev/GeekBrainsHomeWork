// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

using static System.Console;
Clear();

Write("Введите числа через запятую без пробелов: ");
string inputNumbers = ReadLine()!;

int[] StringToIntArrya(string value)
{
    return Array.ConvertAll(value.Split(","), s=>int.Parse(s));
}

int CountPositivNumbers(int[] valueArray)
{
    int count = 0;
    foreach (int v in valueArray) {
        if (v > 0) count++;
    }
    return count;
}

Write("Количество положительных чисел из введёных, равно: " + CountPositivNumbers(StringToIntArrya(inputNumbers)));
