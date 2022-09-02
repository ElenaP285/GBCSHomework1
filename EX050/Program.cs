// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
namespace EX050
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
                    // Console.Write(" ");
                }
                Console.WriteLine(" ");
            }

            Console.WriteLine("Введите позицию элемента для поиска в сгенерированном двумерном массиве");
            Console.WriteLine("Индекс 1:");
            if (int.TryParse(Console.ReadLine(), out int nIndex))
            { }
            else
            {
                Console.WriteLine("Проверьте правильность ввода!");
            }
            Console.WriteLine("Индекс 2:");
            if (int.TryParse(Console.ReadLine(), out int mIndex))
            { }
            else
            {
                Console.WriteLine("Проверьте правильность ввода!");
            }

            checkArrIndex(nIndex, mIndex);

            void checkArrIndex(int nIndex, int mIndex)
            {
                if ((nIndex >= 0) && (nIndex < nSize) && (mIndex >= 0) && (mIndex < mSize))
                {
                    Console.WriteLine($"Значение элемента с индексом [{nIndex},{mIndex}] равно {arrayInt[nIndex, mIndex]}.");
                }
                else
                {
                    Console.WriteLine($"Элемента с индексом [{nIndex},{mIndex}] в массиве не существует!");
                }
            }
        }
    }
}

