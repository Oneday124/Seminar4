// Задать массив, заполнить случайными положительными трехзначными числами. Показать количество чктных и нечетных чисел
void PrintArray (int[] array)
{
    foreach(var element in array)
    Console.Write($"{element} ");
}

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
}

void Check(int[] array)
{
int even = 0;
int odd = 0;   
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) even = even + 1;
        else odd = odd + 1;
    }
Console.WriteLine($"Количество четных чисел = {even}");
Console.WriteLine($"Количество нечетных чисел = {odd}");
}

Console.Write("Введите длинну массива: ");
int lenght = int.Parse(Console.ReadLine() ??"0");
int[] array = new int[lenght];

FillArray(array);
PrintArray(array);
Console.WriteLine();

Check(array);

