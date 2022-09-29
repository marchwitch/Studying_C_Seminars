// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] CopyArray(int[] collection)
{
    int[] copy = new int[collection.Length];
    for (int i = 0; i < collection.Length; i++)
    {
        copy[i] = collection[i];
    }
    return copy;
}

void PrintArray(int[] coll)
{
    int length = coll.Length; 
    int index = 0; 
    while(index < length)
    {
        Console.Write($"{coll[index]} ");  
        index++;      
    }
}

int[] array = {1,2,3,4,5};
var tmp = CopyArray(array);
PrintArray(tmp);