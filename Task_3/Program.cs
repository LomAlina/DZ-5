// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double [8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,10);
}
Console.WriteLine($"Исходный массив: [{String.Join(", ", array)}]");

double maxNumber = array[0];
double minNumber = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (array[i] > maxNumber)
    {
        maxNumber = array[i];
    }
    if (array[i] < minNumber)
    {
        minNumber = array[i];
    }
}

double difference = maxNumber - minNumber;

Console.WriteLine($"Разница между максимальным и минимальным элементом: {difference}");