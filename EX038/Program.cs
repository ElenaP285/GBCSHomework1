// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Задача 38.");
Console.WriteLine("Задайте размерность массива: ");
string arrSize;
arrSize = Console.ReadLine();
if ((int.TryParse(arrSize, out int intarrSize)) && (intarrSize > 0))
{
    double diffElemens;
    double maxElement;
    double minElement;
    double[] array = new double[intarrSize];
    for (int i = 0; i < intarrSize; i++)
    {
        array[i] = new Random().Next(1, 99);
        Console.Write(array[i] + ", ");
    }
    
    Console.WriteLine();
    diffElemens = 0;
    maxElement = array[0];
    minElement = array[0];
    for (int i = 1; i < intarrSize; i++)
    {
        if (array[i]<minElement)
        {
            minElement = array[i];          
        }
        if (array[i]>maxElement)
        {
            maxElement = array[i];          
        }
    }
    diffElemens=maxElement - minElement;
    Console.Write("Разница между максимальным и минимальным элементами массива = ");
    Console.WriteLine(diffElemens);
}
else
{
    Console.WriteLine("Проверьте правильность ввода!");
}


