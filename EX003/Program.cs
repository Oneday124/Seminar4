// Найти сумму чисел одномерного массива стоящих на нечетной позиции

void PrintArray(int[] array)
{
    foreach(var element in array)
    Console.Write($"{element} ");
}
void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,10);
    }
}

int Check(int[] array)
{
int sumOdd = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 0) sumOdd = sumOdd + array[i];
    }
return sumOdd;
}

Console.Write("Введите длинну массива: ");
int lenght = int.Parse(Console.ReadLine() ??"0");
int[] array = new int[lenght];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int sumOdd = Check(array);
Console.WriteLine($"{sumOdd}");
