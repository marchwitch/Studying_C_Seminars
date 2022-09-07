// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

Console.WriteLine("Enter N:");
int N = Convert.ToInt32(Console.ReadLine());
GetDashboard(N);

void GetDashboard(int num)
{
    int count = 1;
    while(count <= Math.Abs(num))
    {
        Console.WriteLine($"Квадрат числа {count} = {count*count}");
        count++;
    }
}