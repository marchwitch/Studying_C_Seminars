// Задача 1: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28; 4 -> 10; 8 -> 36

int Prompt (string message)
{
    Console.Write(message);
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int SumNumbers(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}

int SumNumbersGauss(int number)
{
    return (number*(1 + number)) / 2;
}

int num = Prompt("Введите число > ");
int summa = SumNumbers(num);
Console.WriteLine($"Сумма чисел равна {summa}");
Console.WriteLine($"Сумма чисел по Гауссу равна {SumNumbersGauss(num)}");