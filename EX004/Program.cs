// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

void PrintArray(int[] array)
{
    foreach(int element in array)
    Console.Write($"{element} ");
}
void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 100);
}
int Chech(int[] array)
{
    int result = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] >= 10 & array[i] <= 99) result++;
    return result;
}

int[] array = new int[123];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int result = Chech(array);
Console.WriteLine(result);
