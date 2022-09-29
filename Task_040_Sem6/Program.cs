// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

int Prompt (string message)
{
    Console.Write(message);
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

bool CheckTriangle(int a, int b, int c)
{
    return a < c + b && b < a + c && c < a + b;
}

int num1 = Prompt("Введите число 1: ");
int num2 = Prompt("Введите число 2: ");
int num3 = Prompt("Введите число 3: ");
Console.WriteLine(CheckTriangle(num1, num2, num3));