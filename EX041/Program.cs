// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

namespace EX041
{
    class Program
    {
        static void Main(string[] args)
        {
            string dStrArr;
            int index = 0;
            int counterPlus = 0;
            Console.WriteLine("Введите числа через запятую для проверки: ");
            dStrArr = Console.ReadLine();
            string[] dParseArr = new string[dStrArr.Length];
            for (int i = 0; i < dStrArr.Length; i++)
            {
                if ((dStrArr[i] != ','))
                {
                    dParseArr[index] = dParseArr[index] + dStrArr[i].ToString();
                    if (double.TryParse(dParseArr[index] + "", out double doublBsaeNum)||(dParseArr[index].ToString()=="-"))
                    { }
                    else
                    {
                        Console.WriteLine("Проверьте правильность ввода!");
                        Environment.Exit(0);
                    }
                }
                else
                {
                    index++;
                }
            }
            Console.Write("Числа больше нуля:  ");
            for (int j = 0; j <= index; j++)
            {
                if (double.TryParse(dParseArr[j] + "", out double doublBsaeNum) && (Convert.ToDouble(dParseArr[j])>0))
                {
                    Console.Write(dParseArr[j] + ", ");
                    counterPlus++;
                }
                else
                {
                    //Console.Write(dParseArr[j] + " ]");
                }
            }
            Console.WriteLine("");
            Console.Write($"Среди введенных Вами чисел {counterPlus} больше нуля.");
            Console.WriteLine("");
        }
    }
}