// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3; Если N = 3 -> 0 1 1; Если N = 7 -> 0 1 1 2 3 5 8

int Prompt (string message)
{
    Console.Write(message);
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

void GetNumbersFibonacci(int num)
{
    int firstNum = 0;
    int secondNum = 1;
    Console.WriteLine(firstNum);
    Console.WriteLine(secondNum);

    for (int i = 3; i <= num; i++)
    {
        Console.WriteLine(secondNum + firstNum);
        int tmp = secondNum;
        secondNum = firstNum + secondNum;
        firstNum = tmp;
    }
}

int number = Prompt("Введите число: ");
GetNumbersFibonacci(number);