// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(GetRange(num));

string GetRange(int quater)
{
    string result;
    if(quater == 1)
    {
        result = "x > 0 and y > 0";
    }
    else if(quater == 2)
    {
        result = "x < 0 and y > 0";
    }
    else if(quater == 3)
    {
        result = "x < 0 and y < 0";
    }
    else
    {
        result = "x > 0 and y < 0";
    }
    return result;
}