/*
Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю последовательность (сдвиг - циклический) на |K| 
элементов вправо, если K – положительное и влево, если отрицательное.

Входные данные
Первая строка входного файла INPUT.TXT содержит натуральное число N, во второй строке записаны N целых чисел Ai, 
а в последней – целое число K. (1 ≤ N ≤ 105, |K| ≤ 105, |Ai| ≤ 100).

Выходные данные
В выходной файл OUTPUT.TXT выведите полученную последовательность.

Примеры
№	INPUT.TXT	OUTPUT.TXT
1	5
5 3 7 4 6
3	7 4 6 5 3
2	5
5 3 7 4 6
-3	4 6 5 3 7
*/

void sort(int n, int move)
{
    int[] array = new int[n];

    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите {i+1} элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        //array[i] = new Random().Next(1, 10);
    }
    Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");

    if (move < 0)
    {
        for (int l = 0; l < Math.Abs(move); l++)
        {
            int temp1 = array[n - 1];
            array[n - 1] = array[0];
            for (int i = 0; i < (n - 2); i++)
            {
                int temp2 = array[i + 1];
                array[i] = array[i + 1];
            }
            array[n - 2] = temp1;
        }
    }
    else if (move > 0)
    {
        for (int l = 0; l < Math.Abs(move); l++)
        {
            int temp1 = array[0];
            array[0] = array[n - 1];
            for (int i = (n - 1); i > 1; i = i - 1)
            {
                int temp2 = array[i];
                array[i] = array[i - 1];
            }
            array[1] = temp1;
        }
    }
    Console.WriteLine($"Результат: [{string.Join(", ", array)}]");
}

Console.Clear();
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
sort(n, m);