Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int secondNumber = -number - 1;

while (secondNumber < number)
{
    secondNumber ++;
    Console.WriteLine(secondNumber);
}