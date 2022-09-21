//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
namespace EX058
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность матрицы NxN: ");
            if (int.TryParse(Console.ReadLine(), out int nSize))
            { }
            else
            {
                Console.WriteLine("Проверьте правильность ввода!");
            }
            int mSize=nSize;
            int[,] matrix1 = new int[nSize, mSize];
            int[,] matrix2 = new int[nSize, mSize];
            for (int i = 0; i < nSize; i++)
            {
                for (int j = 0; j < mSize; j++)
                {
                    matrix1[i, j] = new Random().Next(1, 10);
                    matrix2[i, j] = new Random().Next(1, 10);
                }
            }
            Console.WriteLine("Матрица1: ");
            for (int i = 0; i < nSize; i++)
            {
                for (int j = 0; j < mSize; j++)
                {
                    Console.Write(matrix1[i, j] + "\t");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("Матрица2: ");
            for (int i = 0; i < nSize; i++)
            {
                for (int j = 0; j < mSize; j++)
                {
                    Console.Write(matrix2[i, j] + "\t");
                }
                Console.WriteLine(" ");
            }

            matrixMulti();

            void matrixMulti()
            {
                Console.WriteLine("------Произведение матриц---------");
                int[,] matrixP = new int[nSize, mSize];

                for (int i = 0; i < matrix1.GetLength(0); i++)
                {

                    for (int j = 0; j < matrix2.GetLength(1); j++)
                    {
                        for (int k = 0; k < matrix2.GetLength(0); k++)
                        {
                            matrixP[i, j] += matrix1[i, k] * matrix2[k, j];
                        }
                    }
                }
                matrixPrint(matrixP);
            }
            static void matrixPrint(int[,] matrixP)
            {
                Console.WriteLine(" ");
                for (int i = 0; i < matrixP.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixP.GetLength(1); j++)
                    {
                        Console.Write(matrixP[i, j] + "\t");
                    }
                    Console.WriteLine(" ");
                }
            }
        }
    }
}
