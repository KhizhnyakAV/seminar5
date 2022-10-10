// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива");

double[] array = new double[4];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.NextDouble() * 100;
    array[i] = Math.Round(array[i], 2);
}

System.Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    System.Console.Write($"{array[i]}  ");
}
System.Console.WriteLine("]");

double min = array[0];
double max = array[1];
if (min > max) { min = array[1]; max = array[0];};

for (int i = 0; i < array.Length; i++)

{
    if (min > array[i]) { min = array[i];};
    if (max < array[i]) { max = array[i];};
}

double diff = max - min;
System.Console.WriteLine(diff);