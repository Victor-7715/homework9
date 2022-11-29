// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

Console.WriteLine("Введите количество строк ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] numb = new int[lines, columns];
FillArray(numb);
PrintArray(numb);

for (int i = 0; i < numb.GetLength(0); i++)
{
    for (int j = 0; j < numb.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < numb.GetLength(1) - 1; z++)
        {
            if (numb[i, z] <  numb[i, z + 1])
            {
                int temp = 0;
                temp = numb[i, z];
                numb[i, z] = numb[i, z + 1];
                numb[i, z + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями: ");
PrintArray(numb);

void FillArray(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0,10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine("");
    }
}