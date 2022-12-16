/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/
string summ(string number)
{
    if (number[0] == '-') number = number.Substring(1);
    int sum = 0;
    for (int i = 0; i < number.Length; i++)
    {
        int temp = Convert.ToInt32(number[i].ToString());
        sum += temp;
    }
    number = Convert.ToString(sum);
    return number;
}
Console.Clear();
Console.Write("Введите число: ");
string? number = Console.ReadLine();
Console.WriteLine($"Сумма всех чисел равна: {summ(number)}");
