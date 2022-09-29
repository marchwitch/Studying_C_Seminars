// Задача *: Напишите программу, которая задаёт массив из 8 элементов случайными числами
//  и выводит их на экран. Также ищет второй максимум (число меньше максимального элемента, но больше всех остальных) 

int[] CreateArray()
{
    Random rnd = new Random();
    int[] array = new int[8];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0,10);
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

int FindSecondMax(int[] numbers)
{
    int firstMax = numbers[0];
    int secondMax = 0;

    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > firstMax)
        {
            secondMax = firstMax;
            firstMax = numbers[i];
        }
        else if (numbers[i] > secondMax && numbers[i] != firstMax)
        {
            secondMax = numbers[i];
        }
    }
    return secondMax;
}

int[] arr = CreateArray();
PrintArray(arr);
Console.WriteLine();
int secondMax = FindSecondMax(arr);
Console.WriteLine($"Второй максимум = {secondMax}");