// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
string FiveDNum;
Console.WriteLine("Введите пятизначное число: ");
FiveDNum=Console.ReadLine();
if ((FiveDNum.Length ==5) &&  (int.TryParse(FiveDNum,out int intResult)) && (intResult>0) )
 {
    if ((FiveDNum[0]==FiveDNum[4])&&(FiveDNum[1]==FiveDNum[3]))
     {
       Console.WriteLine("ДА - Введенное Вами число является палиндромом.");
     }
    else
     {
       Console.WriteLine("НЕТ - Введенное Вами число НЕ является палиндромом."); 
     }
 }
else 
 { 
    Console.WriteLine("Проверьте правильность ввода пятизначного числа!");
 }
