// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] CreateArray()
{
    Random rnd = new Random();
    int[] array = new int[12];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-9,10);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }
}

int FindSumElementAboveZero (int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] >= 0)
        {
            sum += numbers[i];
        }
    }
    return sum;
}

int FindSumElementBelowZero (int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < 0)
        {
            sum += numbers[i];
        }
    }
    return sum;
}

int[] arr = CreateArray();
PrintArray(arr);
Console.WriteLine();
int positiveSum = FindSumElementAboveZero(arr);
int negativeSum = FindSumElementBelowZero(arr);

Console.WriteLine($"Сумма положительных элементов массива равна = {positiveSum}");
Console.WriteLine($"Сумма отрицательных элементов массива равна = {negativeSum}");