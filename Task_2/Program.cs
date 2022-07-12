// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int [8];
int size = array.Length;
int sumElements = 0;

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(1,10);
    if (i % 2 != 1)
    {
    sumElements += array[i];
    }
}

Console.WriteLine($"Сумма элементов на нечетных позициях: {sumElements}");
Console.WriteLine($"Исходный массив: [{String.Join(", ", array)}]");