// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int Prompt (string message)
{
    Console.Write(message);
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int[] FillArray()
{
    int[] array = new int[10];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10,11);
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

bool FindNumber(int[] collection, int number)
{
    bool result = false;
    for (int i = 0; i < collection.Length; i++)
    {
      if(number == collection[i])
      {
        result = true;
      }
    }
    return result;
}

int num = Prompt("Введите число: ");
int[] arr = FillArray();
PrintArray(arr);
Console.WriteLine();
Console.WriteLine(FindNumber(arr, num));