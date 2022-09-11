// Написать программу замены элементов массива на противоположные
void PrintArray(int[] array)
{
    foreach(var element in array)
    Console.Write($"{element} ");
}

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
}

void Replacement(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
         array[i] = array[i] * -1;
    }
}
Console.WriteLine("Введите длинну масива: ");
int lenght = int.Parse(Console.ReadLine() ??"0");

int[] array = new int[lenght];

FillArray(array);
PrintArray(array);
Console.WriteLine();

Replacement(array);
PrintArray(array);


