// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве");

int[] array = new int[4];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(100, 999);
}

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if ((array[i] % 2) == 0) {count++;};
}

System.Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    System.Console.Write($"{array[i]}  ");
}
System.Console.WriteLine("]");
System.Console.WriteLine(count);
