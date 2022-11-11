// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

Console.WriteLine("Введите номер строки ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] numb = new int [10, 10];
FillArray(numb);
PrintArray(numb);

if (n > numb.GetLength(0) || m > numb.GetLength(1))
{
    Console.WriteLine("ERROR");
}
else
{
    Console.WriteLine($"Значение строки {n} и столбца {m} равно {numb[n-1,m-1]}");
}


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i,j] = new Random().Next(-100,101) ;
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]  + "\t");
        }
        Console.WriteLine();   
    }
}