// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1

int[] FillArray()
{
    int[] array = new int[123];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,1001);
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

int FindNumber(int[] collection)
{
    int amount = 0;
    for (int i = 0; i < collection.Length; i++)
    {
      if(collection[i]>= 10 && collection[i]<= 99)
      {
        amount++;
      }
    }
    return amount;
}

int[] arr = FillArray();
PrintArray(arr);
Console.WriteLine();
Console.WriteLine(FindNumber(arr));
