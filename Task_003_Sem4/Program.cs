// Задача 2: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24; 5 -> 120

int Prompt (string message)
{
    Console.Write(message);
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

// int MultiplicationNumbers(int number)
// {
//     int multiplication = 1;
//     for (int i = 1; i <= number; i++)
//     {
//         multiplication = multiplication*i;
//     }
//     return multiplication;
// }

int FindFact(int number)
{
    int fact = 1;
    while (number > 0)
    {
        fact *= number;
        number = number - 1;
    }
    return fact;
}


int num = Prompt("Введите число > ");
// int multipl = MultiplicationNumbers(num);
Console.WriteLine($"Произведение чисел равно {FindFact(num)}");