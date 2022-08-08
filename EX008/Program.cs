// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int numbermax, counter;
Console.WriteLine("Введите число от 1 до N");
numbermax = Convert.ToInt32(Console.ReadLine());
counter = 1;
while (counter <= numbermax)
{
    if (counter % 2 == 0)
    {
        Console.Write(counter);
        Console.Write(", ");
    }
    counter = counter + 1;
}

