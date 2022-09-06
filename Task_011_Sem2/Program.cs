// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int randomNum = new Random().Next(100, 1000);
Console.WriteLine(randomNum);

// int digit1 = randomNum / 100;
// int digit2 = randomNum % 10;
// Console.WriteLine(digit1);
// Console.WriteLine(digit2);
// int digit3 = digit1*10 + digit2;
// Console.WriteLine(digit3);

int DeleteSecondNumber(int threeDigitNum)
{
    int digit1 = threeDigitNum / 100;
    int digit2 = threeDigitNum % 10;
    int digit3 = digit1*10 + digit2;
    return digit3;
}

int newNumber = DeleteSecondNumber(randomNum);
Console.WriteLine(newNumber);