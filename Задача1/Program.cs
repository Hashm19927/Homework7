/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

double[,] array =new double[3,4];

for (int i=0; i<array.GetLength(0);i++) // строки
{
    for (int j=0; j<array.GetLength(0);j++) //столбцы
    {
        array[i,j]=Convert.ToDouble(new Random().Next(10))/10;
        Console.Write($"{array[i,j]}");
    }
    Console.WriteLine();
}