//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
namespace EX066
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение M: ");
            if (int.TryParse(Console.ReadLine(), out int mSize))
            { }
            else
            {
                Console.WriteLine("Проверьте правильность ввода! Необходимо ввести натуральное число.");
                Environment.Exit(0);
            }
            Console.WriteLine("Введите значение N: ");
            if (int.TryParse(Console.ReadLine(), out int nSize))
            { }
            else
            {
                Console.WriteLine("Проверьте правильность ввода! Необходимо ввести натуральное число.");
                Environment.Exit(0);
            }
            int[] arrNatNums = new int[(nSize+1) - mSize];
            for (int i = 0; i <= (nSize - mSize) ; i++)
            {
                arrNatNums[i] = mSize + i;
            }          
          Console.WriteLine($"Натуральные числа в промежутке от {mSize} до {nSize}: ");
          arrPrintSum(arrNatNums,mSize,nSize);
        }
       
        static void arrPrintSum(int[] arrP,int M, int N)
        {
            int arrSum=0;
            Console.WriteLine(" ");
            for (int i = 0; i < arrP.GetLength(0); i++)
            {
                Console.Write(arrP[i] +","+ "\t");
                arrSum+=arrP[i];
            }
            Console.WriteLine(" ");
            Console.WriteLine($"Cумма натуральных элементов в промежутке от {M} до {N} = {arrSum}");
        }
    }
}
