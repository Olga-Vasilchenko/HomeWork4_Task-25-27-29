// Задача 27. Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigits(int num)
{
    int count = 0;
    int sum = 0;
    while (num > 0)
    {
        count = num % 10;
        sum = sum + count;
        num = num / 10;
    }
    return sum;
}

if (number < 0) number = -number;
int result = SumDigits(number);
Console.WriteLine($"Сумма цифр в числе {number} --> {result}");