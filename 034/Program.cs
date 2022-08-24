// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] createArray()
{
    var random = new Random();
    var result = new int[10];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(100, 1000);
    }
    return result;
}

int Numbers(int[] array)
{
    var result = 0;
    for (long i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            result += 1;
    }
    return result;
}

void printArray(int[] array)
{
    Console.Write("[");
    for (var i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
            Console.Write(", ");
    }
    Console.Write("]");
}

var array = createArray();

Console.WriteLine("Сгенерировали массив из 10 элементов в диапазоне [100, 999]:");
printArray(array);

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Количество четных чисел в массиве: " + Numbers(array));
