// В указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
void PrintArray(int[] array)
{
    foreach(int element in array)
    Console.Write($"{element} ");
}
void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}
int MinMax(int[] array)
{
    int min = array[0];
    int max = 0;
    int result = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
        if(array[i] > max) max = array[i];
    }
    result = max - min;
    return result;
}
int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int result = MinMax(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {result}");