// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101; 3  -> 11; 2  -> 10

int Prompt (string message)
{
    Console.Write(message);
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

string GetNumber(int num)
{
    string result = "";
    while(num > 0)
    {
        result = num % 2 + result;
        num = num / 2;
    }
    return result;
}

int number = Prompt("Введите число: ");
Console.WriteLine(GetNumber(number));