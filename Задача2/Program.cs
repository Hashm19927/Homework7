/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

Console.WriteLine("введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [5,5];

for (int i=0; i<numbers.GetLength(0);i++)
{
    for (int j=0; j<numbers.GetLength(0);j++)
    {
        numbers[i,j]=new Random().Next(10);
        Console.Write($"{numbers[i,j]+" "}");
    }
    Console.WriteLine();
}

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.Write($"Строка -> {n},столбец -> {m} = элемент {numbers[n-1,m-1]}");
}