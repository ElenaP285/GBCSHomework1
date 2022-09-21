//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
namespace EX056
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

            calcArrayStrSum();

            void calcArrayStrSum()
            {
                int minArSumm, tmpSumm, strNum;
                minArSumm = 0;
                tmpSumm = 0;
                strNum = 0;
                for (int i = 0; i < nSize; i++)
                {
                    tmpSumm = 0;
                    for (int j = 0; j < mSize; j++)
                    {

                        tmpSumm += arrayInt[i, j];
                    }
                    if (i == 0)
                    {
                        minArSumm = tmpSumm;
                        strNum = i + 1;
                    }
                    if (tmpSumm < minArSumm)
                    {
                        minArSumm = tmpSumm;
                        strNum = i + 1;
                    }
                }
                Console.WriteLine($"Строка с наименьшей суммой элементов №{strNum}. ");

            }
        }
    }
}

