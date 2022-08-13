// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
string ThreeDNum;
Console.WriteLine("Введите число: ");
ThreeDNum=Console.ReadLine();
if ((ThreeDNum.Length >=3) && (int.TryParse(ThreeDNum,out int intResult)))
 {
    if ((intResult<0))
      { 
         if (ThreeDNum.Length >=4)
          {
            Console.Write("Третья цифра введенного Вами числа: ");
            Console.WriteLine(ThreeDNum[3]);
            Environment.Exit(0);
          } 
          else
          {
            Console.WriteLine("Третьей цифры в введенном Вами числе нет, проверьте правильность ввода числа!");         
            Environment.Exit(0);
          }
      }
    Console.Write("Третья цифра введенного Вами числа: ");
    Console.WriteLine(ThreeDNum[2]);   
 }
else 
 { 
    Console.WriteLine("Третьей цифры в введенном Вами числе нет, проверьте правильность ввода числа!");
 }

