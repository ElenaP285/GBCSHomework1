// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

namespace EX023
{
    class Program
    {
        static void toCube(int CubeDNum)
        {
            int Counter = 1;
            int cubeResult;
            while (Counter <= CubeDNum)
            {
                cubeResult = Counter * Counter * Counter;
                Console.Write(cubeResult);
                if (Counter == CubeDNum)
                {
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.Write(", ");
                }
                Counter++;
            }
        }

        static void Main(string[] args)
        {
            string CubeDNum;
            Console.WriteLine("Введите число от 1 до N для расчета таблицы кубов: ");
            CubeDNum = Console.ReadLine();
            if ((int.TryParse(CubeDNum, out int intCubeDNum)) && (intCubeDNum > 0))
            {
                toCube(intCubeDNum);
            }
            else
            {
                Console.WriteLine("Проверьте правильность ввода!");
            }
        }
    }
}