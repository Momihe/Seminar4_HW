/*
Задача 29: Напишите программу, которая спрашивает у 
пользователя кол-во элементов массива, затем сами элементы. 
Программ должна вывести массив на экран.

8
1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
*/

void mas(int total)
{
    string[] array = new string[total];
    for (int i = 0; i < total; i++)
    {
        Console.Write($"Введите {i+1}-й элемент массива: ");
        array[i] = Console.ReadLine();
    }

//string s10 = string.Join($[{", "}], array);
Console.WriteLine($"[{string.Join(", ", array)}]");
}

Console.Clear();
Console.Write("Введите количество элементов: ");
int m = Convert.ToInt32(Console.ReadLine());
while (m < 1)
    {
    Console.Write("Количество элементов должно быть больше нуля.\nВведите количество элементов: ");
    m = Convert.ToInt32(Console.ReadLine());
    }
mas(m);
