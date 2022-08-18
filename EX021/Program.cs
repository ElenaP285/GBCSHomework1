// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
using System;
namespace EX021
{
    class Program
    {
        static void toDist(int[] point1Coord, int[] point2Coord)
        {
            double distResult;
            distResult = Math.Sqrt(Math.Pow((point1Coord[0] - point2Coord[0]), 2.0) + Math.Pow((point1Coord[1] - point2Coord[1]), 2.0) + Math.Pow((point1Coord[2] - point2Coord[2]), 2.0));
            Console.Write("Расстояние между точками в 3D пространстве = ");
            Console.WriteLine(distResult);
        }

        static void Main(string[] args)
        {
            int[] point1Coord = { 0, 0, 0 };
            int[] point2Coord = { 0, 0, 0 };
            string CoordNum;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Введите {i + 1} координату первой точки: ");
                CoordNum = Console.ReadLine();
                if (int.TryParse(CoordNum, out int intCoordNum))
                {
                    point1Coord[i] = intCoordNum;
                }
                else
                {
                    Console.WriteLine("Проверьте правильность ввода!");
                    Environment.Exit(0);
                }
            }
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine($"Введите {j + 1} координату второй точки: ");
                CoordNum = Console.ReadLine();
                if (int.TryParse(CoordNum, out int intCoordNum))
                {
                    point2Coord[j] = intCoordNum;
                }
                else
                {
                    Console.WriteLine("Проверьте правильность ввода!");
                    Environment.Exit(0);
                }
            }
            Console.WriteLine("Точка 1 (" + point1Coord[0] + ", " + point1Coord[1] + ", " + point1Coord[2] + ")");
            Console.WriteLine("Точка 2 (" + point2Coord[0] + ", " + point2Coord[1] + ", " + point2Coord[2] + ")");
            toDist(point1Coord, point2Coord);
        }
    }
}