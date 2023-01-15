// Напишите программу, реализующую метод, который формирует массив случайных целых чисел из 8 элементов и выводит их на экран.
using static System.Console;
Clear();

void RandomNumArray(int len)
{
    Random rnd = new Random();
    int[] res = new int[len];
    for (int i = 0; i < len; i++) {
        res[i] = rnd.Next(100);
    }
    for (int n = 0; n < res.Length; n++) {
        Write(res[n]);
        if ((len - 1) > n) Write(",");
    }
}

Write("Введите длину массива: ");
if (int.TryParse(ReadLine(), out int len)){}
else Write("Ошибка ввода!");

RandomNumArray(len);