// Напишите программу реализующую методы формирования массива, заполненного случайными вещественными числами и вычисления разницы между максимальным и минимальным элементов массива.

using static System.Console;
Clear();

double[] randNumbersArray()
{
    int len = 10;
    int min = 1;
    int max = 100;
    int range = max - min;
    double[] arr = new double[len];
    for (int i = 0; i < arr.Length; i++) {
        double rand_n = new Random().NextDouble();
        arr[i] = Math.Round((rand_n * range) + min, 2);
    }
    return arr;
}

double max(double[] arr)
{
    double max = arr[0];
    foreach (double num in arr) {
        if (num > max) max = num;
    }
    return max;
}

double min(double[] arr)
{
    double min = arr[0];
    foreach (double num in arr) {
        if (num < min) min = num;
    }
    return min;
}

double[] cur_arr = randNumbersArray();
WriteLine(max(cur_arr) - min(cur_arr));