//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
namespace EX060
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность трехмерного(NxNxN) массива N: ");
            if (int.TryParse(Console.ReadLine(), out int nSize))
            { }
            else
            {
                Console.WriteLine("Проверьте правильность ввода!");
            }
            int[,,] matrix1 = new int[nSize, nSize, nSize];
            int[] exclNums = new int[nSize * nSize * nSize];
            int counter1 = 1;
            int tmpNum;
            int flg1 = 1;
            exclNums[0] = new Random().Next(10, 99);
            for (int i = 0; i < nSize; i++)
            {
                for (int j = 0; j < nSize; j++)
                {
                    for (int k = 0; k < nSize; k++)
                    {
                        while (flg1 > 0)
                        {
                            flg1 = 0;
                            tmpNum = new Random().Next(10, 99);
                            for (int nn = 0; nn < counter1; nn++)
                            {
                                if (exclNums[nn] == tmpNum) { flg1++; }
                                else { }
                            }
                            if (flg1 == 0)
                            {
                                matrix1[i, j, k] = tmpNum;
                                exclNums[counter1 - 1] = tmpNum;
                                counter1++;
                            }
                        }
                        flg1 = 1;
                    }
                }
            }

            matrixPrint(matrix1);
        }
        static void matrixPrint(int[,,] matrixP)
        {
            Console.WriteLine("Сгенерированный массив: ");
            for (int i = 0; i < matrixP.GetLength(0); i++)
            {
                for (int j = 0; j < matrixP.GetLength(1); j++)
                {
                    for (int k = 0; k < matrixP.GetLength(2); k++)
                    {
                        Console.Write(matrixP[i, j, k] + $"({i},{j},{k})" + "\t");
                    }
                }
                Console.WriteLine(" ");
            }
        }
    }
}
