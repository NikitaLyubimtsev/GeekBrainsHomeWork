// Напишите программу реализующую методы формирования массива, заполненного случайными положительными трёхзначными числами, и подсчета количества чётных чисел в массиве.

using static System.Console;
Clear();

// Variant 1
int evenNumbersCount()
{
    int cnt = 0;
    int len = 8;
    int[] random_numbers_array = new int[len];

    for (int i = 0; i < random_numbers_array.Length; i++) {
        int num = new Random().Next(100, 999);
        random_numbers_array[i] = num;
        if ((num % 2) == 0) cnt++;
    }
    return cnt;
}

//Write(evenNumbersCount());

// Variant 2
int[] randomArray()
{
    int len = 8;
    int[] random_numbers_array = new int[len];
    for (int i = 0; i < random_numbers_array.Length; i++) {
        random_numbers_array[i] = new Random().Next(100, 999);
    }
    Write("[" + String.Join(",", random_numbers_array) + "] -> ");
    return random_numbers_array;
}

int evenNumbCount(int[] arr)
{
    int cnt = 0;
    foreach(int num in arr) {
        if ((num % 2) == 0) cnt++;
    }
    return cnt;
}

Write(evenNumbCount(randomArray()));