// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int FindMax(int num1, int num2)
{
    if(num1 > num2)
    {
        return num1;
    }
    return num2;
}

int randomNum = new Random().Next(10, 100);
Console.WriteLine(randomNum);
int digitFirst = randomNum / 10;
int digitSecond = randomNum % 10;

Console.WriteLine(FindMax(digitFirst, digitSecond));
