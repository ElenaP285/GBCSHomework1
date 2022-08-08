// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int number1, number2;
Console.WriteLine("Введите первое число:");
number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.Write("большее число = ");
    Console.WriteLine(number1);
    Console.Write("меньшее число = ");
    Console.WriteLine(number2);
}
if (number1 < number2)
{
    Console.Write("большее число = ");
    Console.WriteLine(number2);
    Console.Write("меньшее число = ");
    Console.WriteLine(number1);
}
