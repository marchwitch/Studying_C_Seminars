﻿// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

Console.WriteLine("Enter x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double GetDistance(int x1, int y1, int x2, int y2)
{
    double distance = 0;
    distance = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));
    return distance;
}

Console.WriteLine(GetDistance(x1, y1, x2, y2));