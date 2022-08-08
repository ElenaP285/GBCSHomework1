// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int number1, number2, number3, maxnumber;
Console.WriteLine("Введите первое число:");
number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
number3 = Convert.ToInt32(Console.ReadLine());
maxnumber = number1;
if (maxnumber < number2)
  {
    maxnumber = number2;
  }
if (maxnumber < number3)
  {
    maxnumber = number3;
  }
Console.Write("Максимальное число = ");
Console.WriteLine(maxnumber);