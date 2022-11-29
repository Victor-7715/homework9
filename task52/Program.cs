// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// (посмотрите как реализуется произведение матриц, там не просто перемножение элемент на элемент)
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3

int size = InputInt("Размерность матриц: ");
Console.WriteLine("Матрица - А");
int[,] matrixA = new int[size,size];
FillArray(matrixA);
PrintArray(matrixA);
Console.WriteLine();
Console.WriteLine("Матрица - B");
int[,] matrixB = new int[size,size];
FillArray(matrixB);
PrintArray(matrixB);
Console.WriteLine();


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,5);
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


int[,] matrixC = new int[size,size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matrixC[i,j] = matrixC[i,j] + (matrixA[i,k] * matrixB[k,j]);
        }
    }
}
Console.WriteLine("Произведение матриц A*B");
PrintArray(matrixC);

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}