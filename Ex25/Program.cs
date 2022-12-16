/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
Не использовать Math.Pow
3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

int power(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
        }
    return result;    
}
Console.Clear();
Console.Write("Введите число a: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа а(натуральное число): ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1)
    {
        Console.WriteLine("Неверно. Число степени числа а должно быть натуральным.");
        Console.Write("\nВведите степень числа а(натуральное число): ");
        n = Convert.ToInt32(Console.ReadLine());
    }
Console.WriteLine($"{m} в {n}-й степени равно: {power(m, n)} ");
