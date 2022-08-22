// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

namespace EX027
{
    class Program
    {
        static void toSum(string dBsaeNum)
        {
            int Counter = 0;
            int sumResult = 0;
            while (Counter < dBsaeNum.Length)
            {
                if (dBsaeNum[Counter] == '-')
                { Counter++; }
                else
                {
                    sumResult = sumResult + Convert.ToInt32(dBsaeNum[Counter]+"");
                    Counter++;
                }
            }
            Console.Write($"Сумма цифр в числе {dBsaeNum}  = ");
            Console.WriteLine(sumResult);
        }

        static void Main(string[] args)
        {
            string dBsaeNum, dPowNum;
            Console.WriteLine("Введите число для для вычисления суммы цифр: ");
            dBsaeNum = Console.ReadLine();
            if (int.TryParse(dBsaeNum, out int intdBsaeNum))
            {
                toSum(dBsaeNum);
            }
            else
            {
                Console.WriteLine("Проверьте правильность ввода!");
            }
        }
    }
}