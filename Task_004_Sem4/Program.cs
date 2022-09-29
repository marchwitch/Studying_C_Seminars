// Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] CreateArray()
{
    Random rnd = new Random();
    int[] array = new int[8];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0,2);
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

int[] arr = CreateArray();
PrintArray(arr);


// void FillArray (int[] array)
// {
//     int size = array.Length;
//     int index = 0;
//     while (index < size)
//     {
//         array[index] = new Random().Next(0,2);
//         index++;
//     }
// }

// void PrintArray (int[] array1)
// {
//     int length = array1.Length;
//     int position = 0;
//     while (position < length)
//     {
//         Console.Write(array1[position]);
//         position++;
//     }
// }

// int[] collection = new int[8];
// FillArray(collection);
// PrintArray(collection);