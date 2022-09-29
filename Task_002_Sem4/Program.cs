// Задача 1: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3; 78 -> 2; 89126 -> 5

int Prompt (string message)
{
    Console.Write(message);
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int CountDigit (int number)
{
    int count = 0;
    while (number > 0)
    {
        number = number / 10;
        count++;
    }
    return count;
}

int num = Prompt("Введите число > ");
int countOfDigits = CountDigit(num);
Console.WriteLine($"Количество цифр в числе равно {countOfDigits}");