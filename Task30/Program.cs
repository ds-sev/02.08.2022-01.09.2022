// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < 8)
    {
        collection[index] = new Random().Next(0,2);
        index++;
    }
}
Console.Write("[");

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        
        Console.Write($"{col[position]},");
        position++;
    }
}
int[] array = new int[8];

FillArray(array);
PrintArray(array);

Console.Write("]");

    // }
    // }
// int[] array = new int[8];
// Random rand = new Random();
// for (int i = 0; i < array.Length; i++) array[i] = rand.Next(0, 2);

// Console.PrintArray(array[]);

