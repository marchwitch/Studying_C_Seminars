Console.WriteLine("Введите номер дня недели: ");
int numberDay = Convert.ToInt32(Console.ReadLine());

if (numberDay == 1)
{
    Console.WriteLine("Monday");
}
else if (numberDay == 2)
{
    Console.WriteLine("Tuesday");
}
else if (numberDay == 3)
{
    Console.WriteLine("Wednesday");
}
else if (numberDay == 4)
{
    Console.WriteLine("Thursday");
}
else if (numberDay == 5)
{
    Console.WriteLine("Friday");
}
else if (numberDay == 6)
{
    Console.WriteLine("Saturday");
}
else if (numberDay == 7)
{
        Console.WriteLine("Sunday");
}
else 
{
    Console.WriteLine("You entered an invalid number. Enter a number from 1 to 7"); 
}