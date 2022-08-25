// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();

int[] createArray()

{
    var random = new Random();
    var result = new int[10];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(0, 100);
    }
    return result;
}

int MinNumbers(int[] array)
{
    var min = array[0];
    for (long i = 1 ; i < array.Length; i ++)
    {
        if (min > array[i])
            min = array[i];        
    }
    return min;
    
}

int MaxNumbers(int[] array)
{
    var max = array[0];
    for (long i = 1 ; i < array.Length; i ++)
    {
        if (max < array[i])
            max = array[i];
    }
    return max;
    
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
var result = MaxNumbers(array) - MinNumbers(array);
//var result = MaxNumbers() - MinNumbers();

Console.WriteLine("Сгенерировали массив из 10 элементов в диапазоне [0, 100]:");
printArray(array);

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Разница между максимальным и минимальным элементов массива: " + result);