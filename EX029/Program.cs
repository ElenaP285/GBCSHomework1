// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

namespace EX029
{
    class Program
    {
        static void Main(string[] args)
        {
            string dStrArr;
            int index = 0;
            Console.WriteLine("Введите числа через запятую для преобразования в массив: ");
            dStrArr = Console.ReadLine();
            string[] dParseArr = new string[dStrArr.Length];
            for (int i = 0; i < dStrArr.Length; i++)
            {
                if ((dStrArr[i] != ','))
                {
                    dParseArr[index] = dParseArr[index] + dStrArr[i].ToString();
                    if (int.TryParse(dParseArr[index] + "", out int intdBsaeNum))
                    { }
                    else
                    {
                        Console.WriteLine("Проверьте правильность ввода!");
                        Environment.Exit(0);
                    }
                }
                else
                {
                    index++;
                }
            }
            Console.Write("Веденный Вами массив: [ ");
            for (int j = 0; j <= index; j++)
            {
                if (j <= index - 1)
                {
                    Console.Write(dParseArr[j] + ", ");
                }
                else
                {
                    Console.Write(dParseArr[j] + " ]");
                }
            }
            Console.WriteLine("");
        }
    }
}