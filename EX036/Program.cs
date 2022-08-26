// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("Задача 36.");
Console.WriteLine("Задайте размерность массива: ");
string arrSize;
arrSize = Console.ReadLine();
if ((int.TryParse(arrSize, out int intarrSize)) && (intarrSize > 0))
{
    int sumElemens;
    int[] array = new int[intarrSize];
    for (int i = 0; i < intarrSize; i++)
    {
        array[i] = new Random().Next(-99, 99);
        Console.Write(array[i] + ", ");
    }
    
    Console.WriteLine();
    sumElemens = 0;
    for (int i = 0; i < intarrSize; i++)
    {
        if ((i>0 ) && (i % 2 != 0))
        {
            sumElemens+= array[i];          
        }
    }
    Console.Write("Сумма элементов, стоящих на нечетных позициях = ");
    Console.WriteLine(sumElemens);
}
else
{
    Console.WriteLine("Проверьте правильность ввода!");
}


