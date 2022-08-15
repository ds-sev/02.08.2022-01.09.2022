// Задача 26: Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 0;
if (number < 0) number = -number;

while (number  > 0 )
{
    number = number / 10;
    i++;
    // Console.WriteLine(i);
}
Console.WriteLine(i);