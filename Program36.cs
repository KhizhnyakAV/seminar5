// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях");

int[] array = new int[4];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(0, 100);
}

int summ = 0;
for (int i = 0; i < 4;)
{
    summ = summ + array [i];
    i=i+2;
}

System.Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    System.Console.Write($"{array[i]}  ");
}
System.Console.WriteLine("]");
System.Console.WriteLine(summ);