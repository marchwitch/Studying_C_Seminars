// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows,columns];

FillArray(array);
PrintArray(array);
Console.WriteLine();
int LastRow = array.GetLength(0) - 1;

for (int j = 0; j < array.GetLength(1); j++)
{
    int tmp = array[0,j];
    array[0,j] = array[LastRow,j];
    array[LastRow,j] = tmp;
}

PrintArray(array);

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]}\t");
        }
        Console.WriteLine();
    }
}