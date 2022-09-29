// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] CreateArray()
{
    Random rnd = new Random();
    int[] array = new int[10];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-10,11);
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

void ChangeElements(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
      numbers[i] *= -1;
    }
}

int[] arr = CreateArray();
PrintArray(arr);
Console.WriteLine();
ChangeElements(arr);
PrintArray(arr);