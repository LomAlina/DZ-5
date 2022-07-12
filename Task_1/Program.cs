// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int [8];
int size = array.Length;
int evenNumbers = 0;

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(100,1000);
    if (array[i] % 2 == 0)
    {
        evenNumbers++;
    }
}

Console.WriteLine($"Количество чётных чисел в массиве: {evenNumbers}");
Console.WriteLine($"Исходный массив: [{String.Join(", ", array)}]");