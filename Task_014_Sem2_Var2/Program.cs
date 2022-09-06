// 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Multiple7And23(number));

bool Multiple7And23(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}
