// Напишите программу реализующую методы формирования массива, заполненного случайными числами и подсчета суммы элементов, стоящих на нечётных позициях.

using static System.Console;
Clear();

int[] randNumbersArray()
{
    int len = 10;
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++) {
        arr[i] = new Random().Next(-1000, 1000);
    }
    return arr;
}

 int? sumOddIdx(int[] arr)
 {
    int sum = 0;
    int arr_len = arr.Length;
    if (arr_len > 1) {
        int idx = 1;
        while (idx <= arr_len) {
            sum += arr[idx];
            idx += 2;
        }
        return sum;
    } else {
        Write("Ошибка получения данных!");
        return null;
    }
 }

 Write(sumOddIdx(randNumbersArray()));