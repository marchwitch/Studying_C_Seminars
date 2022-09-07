// 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координаты x: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y: ");
int Y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(GetKvadrat(X, Y));

int GetKvadrat(int x, int y)
{
    int sqr = 0;
    if (x > 0 && y > 0)
    {
        sqr = 1;
    }
    else if(x < 0 && y > 0)
    {
        sqr = 2;
    }
    else if(x < 0 && y < 0)
    {
        sqr = 3;
    }
    else if(x > 0 && y < 0)
    {
        sqr = 4;
    }
    return sqr;
}