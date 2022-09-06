// 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Multiple(int num)
{
    if (num % 7 == 0)
    {
        if (num % 23 == 0)
        {
            Console.WriteLine("да");
        }
         else
        {
            Console.WriteLine("нет");
        }
    }
    else
    {
        Console.WriteLine("нет");
    }
}

Multiple(number);
