//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
namespace EX068
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисления функции Аккермана A(m,n) с помощью рекурсии.");
            Console.WriteLine("Введите значение m: ");
            if (int.TryParse(Console.ReadLine(), out int mSize)&& mSize>=0)
            { }
            else
            {
                Console.WriteLine("Проверьте правильность ввода! Необходимо ввести натуральное число.");
                Environment.Exit(0);
            }
            Console.WriteLine("Введите значение n: ");
            if (int.TryParse(Console.ReadLine(), out int nSize)&& nSize>=0)
            { }
            else
            {
                Console.WriteLine("Проверьте правильность ввода! Необходимо ввести натуральное число.");
                Environment.Exit(0);
            }            
            Console.WriteLine($"Значение функции Аккермана A({mSize} , {nSize}) = " + Akkeramn(mSize, nSize));
        }

        static int Akkeramn(int m, int n)
        {
            if (m == 0) return n + 1;
            if (m > 0 && n == 0) return Akkeramn(m - 1, 1);
            if (m > 0 && n > 0) return Akkeramn(m - 1, Akkeramn(m, n - 1));
            return Akkeramn(m, n);
        }
    }
}
