// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

namespace EX025
{
    class Program
    {
        static void toPower(int dBsaeNum, int dPowNum)
        {
            int Counter = 1;
            int powResult = 1;
            while (Counter <= dPowNum)
            {
                powResult = powResult * dBsaeNum;
                Counter++;
            }
            Console.Write($"Результат возведеия числа {dBsaeNum} в степень {dPowNum}  = ");
            Console.WriteLine(powResult);
        }

        static void Main(string[] args)
        {
            string dBsaeNum, dPowNum;
            Console.WriteLine("Введите число для возведения в степень: ");
            dBsaeNum = Console.ReadLine();
            if ((int.TryParse(dBsaeNum, out int intdBsaeNum)) && (intdBsaeNum >= 0))
            {
                Console.WriteLine("Введите показатель степени: ");
                dPowNum = Console.ReadLine();
                if ((int.TryParse(dPowNum, out int intdPowNum)) && (intdPowNum >= 0))
                {
                    toPower(intdBsaeNum, intdPowNum);
                }
                else
                {
                    Console.WriteLine("Проверьте правильность ввода!");
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Проверьте правильность ввода!");
            }
        }
    }
}