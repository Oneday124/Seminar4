// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
void PrintArray(int[] array)
{
    foreach(int element in array)
    Console.Write($"{element} ");
}
void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 10);
}
void Mult (int[] array, int i, int j)
{
    while (i < array.Length / 2)
    {
        int mult = array[i] * array[j];
        Console.WriteLine(mult); 
        j = j - 1;   
        i++;  
    }    
}

int lenght = new Random().Next(0,10);
int[] array = new int[lenght];
FillArray(array);
PrintArray(array);
Console.WriteLine();

Mult(array, 0, array.Length - 1);
 
