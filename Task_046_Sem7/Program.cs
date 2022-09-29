// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

int rows = new Random().Next(3, 6);
int columns = new Random().Next(3, 6);
int[,] array = new int[rows, columns];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(1, 10);
        Console.Write($"{array[i,j]}");
    }
    Console.WriteLine();
}