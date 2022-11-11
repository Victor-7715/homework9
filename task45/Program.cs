// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите кол-во строк ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] num = new int [n,m];
FillArray(num);
PrintArray(num);


for (int i = 0; i < num.GetLength(0); i++)
{
    double avg = 0;
    for (int j = 0; j < num.GetLength(1); j++)
    {
        avg = avg + num[j, i];
    }
    Console.WriteLine(i + 1 +" столбец: " + avg/n);
}
Console.WriteLine();

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i,j] = new Random().Next(0,100);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine("");
    }
}
