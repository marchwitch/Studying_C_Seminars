// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

void Multiple(int num1, int num2)
{
    if (num1 % num2 == 0)
    {
        Console.WriteLine("Кратно");
    }
    else
    {
        Console.WriteLine($"Остаток от деления {num1 % num2}");
    }
}

Multiple(number1, number2);


// Console.WriteLine();
// int result = number1 % number2;
//if (result == 0)
// {
//    Console.WriteLine("Кратно");
// }
// else
// {
//    Console.WriteLine("Не кратно");
//    Console.WriteLine(result);
// }