//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
namespace EX064
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
          Console.WriteLine(" ");
          Console.WriteLine($"Натуральные числа в промежутке от {mSize} до {nSize}: ");
          arrPrint(arrNatNums);
        }
       
        static void arrPrint(int[] arrP)
        {
            Console.WriteLine(" ");
            for (int i = 0; i < arrP.GetLength(0); i++)
            {
                Console.Write(arrP[i] +","+ "\t");
            }
            Console.WriteLine(" ");
        }
    }
}
