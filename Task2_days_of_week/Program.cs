// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите номер дня недели: ");
int numOfDay = Convert.ToInt32(Console.ReadLine());
if (numOfDay == 1)
{
    Console.WriteLine("Понедельник ");
}
else if (numOfDay == 2)
{
    Console.WriteLine("Вторник ");
}
else if (numOfDay == 3)
{
    Console.WriteLine("Среда ");
}
else if (numOfDay == 4)
{
    Console.WriteLine("Четверг ");
}
else if (numOfDay == 5)
{
    Console.WriteLine("Пятница ");
}
else if (numOfDay == 6)
{
    Console.WriteLine("Суббота ");
}
else if (numOfDay == 7)
{
    Console.WriteLine("Воскресенье ");
}
else
{
    Console.WriteLine("Необходимо ввести число в диапазоне от 1 до 7. ");
}

