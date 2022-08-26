// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine("Задача 34.");
Console.WriteLine("Задайте размерность массива: ");
string arrSize;
arrSize = Console.ReadLine();
if ((int.TryParse(arrSize, out int intarrSize)) && (intarrSize > 0))
{
    int CounterDiv2;
    int[] array = new int[intarrSize];
    for (int i = 0; i < intarrSize; i++)
    {
        array[i] = new Random().Next(100, 999);
        Console.Write(array[i] + ", ");
    }
    
    Console.WriteLine();
    CounterDiv2 = 0;
    for (int i = 0; i < intarrSize; i++)
    {
        if (array[i] % 2 == 0)
        {
            CounterDiv2 = CounterDiv2 + 1;          
        }
    }
    Console.Write("Количество четных элементов в массиве = ");
    Console.WriteLine(CounterDiv2);
}
else
{
    Console.WriteLine("Проверьте правильность ввода!");
}


