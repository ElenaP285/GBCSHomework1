// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
string DayNum;
string[] ArrDays= {"1-Пнд-НЕТ","2-Втр-НЕТ","3-Срд-НЕТ","4-Чтв-НЕТ","5-Птн-НЕТ","6-Сбт-ДА","7-Вск-ДА"};
Console.WriteLine("Введите цифру, обозначающую день недели: 1-Пнд, 2-Втр, 3-Срд, 4-Чтв, 5-Птн, 6-Сбт, 7-Вск.");
DayNum=Console.ReadLine();
if ((DayNum.Length ==1) &&  (int.TryParse(DayNum,out int intResultDay)) && intResultDay>0 && intResultDay<8)
 {
    Console.WriteLine(ArrDays[intResultDay-1]);
 }
else 
 { 
    Console.WriteLine("Проверьте правильность ввода!");
 }
