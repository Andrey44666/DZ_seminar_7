// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет.

int[,] Matrix = new int[3, 4];

void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }

}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

GetArray(Matrix);
PrintArray(Matrix);
System.Console.WriteLine();

int i = ReadInt("Введите индекс строки: ");
int j = ReadInt("Введите индекс столбца: ");

if (i < Matrix.GetLength(0) && j < Matrix.GetLength(1))
{
    Console.Write($"Число: {Matrix[i, j]}");
}
else
{
    Console.WriteLine($"Числа в масссиве нет!");
}
int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}
Console.WriteLine();
