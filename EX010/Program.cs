// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
string ThreeDNum;
Console.WriteLine("Введите трехзначное число: ");
ThreeDNum=Console.ReadLine();
if ((ThreeDNum.Length ==3) &&  (int.TryParse(ThreeDNum,out int intResult)))
 {
    Console.Write("Вторая цифра введенного Вами числа: ");
    Console.WriteLine(ThreeDNum[1]);   
 }
else 
 { 
    Console.WriteLine("Проверьте правильность ввода трехзначного числа!");
 }
