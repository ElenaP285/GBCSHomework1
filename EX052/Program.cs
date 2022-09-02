//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
namespace EX052
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива N: ");
            if (int.TryParse(Console.ReadLine(), out int nSize))
            { }
            else
            {
                Console.WriteLine("Проверьте правильность ввода!");
            }
            Console.WriteLine("Введите размерность массива M: ");
            if (int.TryParse(Console.ReadLine(), out int mSize))
            { }
            else
            {
                Console.WriteLine("Проверьте правильность ввода!");
            }
            int[,] arrayInt = new int[nSize, mSize];
            for (int i = 0; i < nSize; i++)
            {
                for (int j = 0; j < mSize; j++)
                {
                    arrayInt[i, j] = new Random().Next(0, 10);
                }
            }
            Console.WriteLine("Сгенерированный массив: ");
            for (int i = 0; i < nSize; i++)
            {
                for (int j = 0; j < mSize; j++)
                {
                    Console.Write(arrayInt[i, j] + "\t");
                }
                Console.WriteLine(" ");
            }

            calcColAVG();

            void calcColAVG()
            {
                double sumCol, avgCol;
                for (int i = 0; i < mSize; i++)
                {
                    sumCol = 0;
                    avgCol = 0;
                    for (int j = 0; j < nSize; j++)
                    {
                        sumCol = sumCol + arrayInt[j, i];
                    }
                    avgCol = sumCol / nSize;
                    Console.WriteLine($"Среднее арифметическое столбца [{i}] равно {Math.Round(avgCol, 2, MidpointRounding.ToEven)}");
                }
            }
        }
    }
}

