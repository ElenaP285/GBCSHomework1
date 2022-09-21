//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
namespace EX054
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

            sortArray();

            void sortArray()
            {
                int maxArMum, tmpNum, stepN;
                for (int i = 0; i < nSize; i++)
                {
                    maxArMum = arrayInt[i, 0];
                    tmpNum = 0;
                    stepN = 1;
                    while (stepN < mSize)
                    {
                        for (int j = stepN; j < mSize; j++)
                        {
                            if (arrayInt[i, j] > maxArMum)
                            {
                                maxArMum = arrayInt[i, j];
                                tmpNum = arrayInt[i, stepN - 1];
                                arrayInt[i, stepN - 1] = arrayInt[i, j];
                                arrayInt[i, j] = tmpNum;
                                j = stepN - 1;
                            }
                        }
                        maxArMum = arrayInt[i, stepN];
                        stepN++;
                    }
                }
                Console.WriteLine("Отсортированный массив: ");
                for (int i = 0; i < nSize; i++)
                {
                    for (int j = 0; j < mSize; j++)
                    {
                        Console.Write(arrayInt[i, j] + "\t");
                    }
                    Console.WriteLine(" ");
                }
            }
        }
    }
}

