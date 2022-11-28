// Задача 25. Напишите цикл, который принимает 
// на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите первое число --> ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = -1;
while (number2 <= 0)
{
Console.Write("Введите второе натуральное число --> ");
number2 = Convert.ToInt32(Console.ReadLine());
if (number2 <= 0) Console.WriteLine("Введено неверное число");
}
int MultDigits(int num1, int num2)
{
    int mult = 1;
    for (int i = 1; i <= num2; i++)
    {
        mult = mult * num1;
    }
    return mult;
}
Console.WriteLine($"Число {number1} в степени {number2} --> {MultDigits(number1, number2)}");