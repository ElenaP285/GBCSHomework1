// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
namespace EX047
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
            double[,] arrayDouble = new double[nSize, mSize];
            for (int i = 0; i < nSize; i++)
            {
                for (int j = 0; j < mSize; j++)
                {
                    arrayDouble[i, j] = Math.Round(new Random().Next(-999, 999) * 0.1, 1, MidpointRounding.ToEven);
                }
            }
            Console.WriteLine("Сгенерированный массив: ");
            for (int i = 0; i < nSize; i++)
            {
                for (int j = 0; j < mSize; j++)
                {
                    Console.Write(arrayDouble[i, j] + "\t");
                    Console.Write("  ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}

