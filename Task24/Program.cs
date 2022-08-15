// Задача 24: Напишите программу, 
// 1. которая принимает на вход число (А) и 
// 2. выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = default;                                         // 0

for (int i = 1; i <= num; i++)
{
    sum = sum + i;                                         // sum += i 
}
Console.WriteLine($"Сумма числел от 1 до {num}: {sum}.");