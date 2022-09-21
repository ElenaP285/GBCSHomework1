//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
namespace EX062
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность двумерного массива NxN: ");
            if (int.TryParse(Console.ReadLine(), out int nSize))
            { }
            else
            {
                Console.WriteLine("Проверьте правильность ввода!");
            }
            int mSize=nSize;
            int counter=1;
            int[,] arrayInt = new int[nSize, mSize];
            
            //Начальное заполнение периметра 
            for (int j = 0; j < mSize; j++)
            {
                arrayInt[0, j] = counter;
                counter++;
            }
            for (int i = 1; i < nSize; i++)
            {
                arrayInt[i, nSize-1] = counter;
                counter++;
            }
            for (int j = nSize-2; j >=0; j--)
            {
                arrayInt[nSize-1, j] = counter;
                counter++;
            }
            for (int i = mSize-2; i > 0; i--)
            {
                arrayInt[i, 0] = counter;
                counter++;
            }
            
            //-----------------
            int i2=1;
            int j2=1;
            while (counter<nSize*mSize)
             { //Заполняем вправо
               while (arrayInt[i2, j2+1]==0)
               {
                arrayInt[i2, j2]=counter;
                counter++;
                j2++;
               }
               //Заполняем вниз
               while (arrayInt[i2+1, j2]==0)
               {
                arrayInt[i2, j2]=counter;
                counter++;
                i2++;
               }
               //Заполняем влево
               while (arrayInt[i2, j2-1]==0)
               {
                arrayInt[i2, j2]=counter;
                counter++;
                j2--;
               }
               //Заполняем вверх
               while (arrayInt[i2-1, j2]==0)
               {
                arrayInt[i2, j2]=counter;
                counter++;
                i2--;
               }
             }

            for (int i = 0; i < nSize; i++)
            {
                for (int j = 0; j < mSize; j++)
                {
                   if (arrayInt[i, j] ==0){arrayInt[i, j] =counter;} 
                }
            }
            
            matrixPrint(arrayInt);
            
            static void matrixPrint(int[,] matrixP)
            {
                Console.WriteLine("Заполненный по спирали массив:");
                Console.WriteLine(" ");
                for (int i = 0; i < matrixP.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixP.GetLength(1); j++)
                    {
                       if (matrixP[i, j] <10)
                       {
                        Console.Write("0"+matrixP[i, j] + "\t");
                       } 
                       else
                       {
                         Console.Write(matrixP[i, j] + "\t");                      
                       }
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");

                }
            }
            
        }
    }
}

