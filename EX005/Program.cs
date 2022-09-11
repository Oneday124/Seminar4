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

int[] array = new int[5];
FillArray(array);
PrintArray(array);
Console.WriteLine();

for(int i = 0; i < array.Length; i++)
{
    int num1 = array[i];
    int num2 = array[5 - i];
    int mult = num1 * num2;
    Console.WriteLine(mult);
}
