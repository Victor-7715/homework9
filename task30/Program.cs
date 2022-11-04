// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива ");
int size = int.Parse(Console.ReadLine());
double[] numb = new double[size];
FillArrayRandomNumbers(numb);
PrintArray(numb);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < numb.Length; i++)
{
    if (max < numb[i])
    {
        max = numb [i];
    }
    if (min > numb[i])
    {
        min = numb[i];
    }
}

Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] numb)
{
    for (int j = 0; j < numb.Length; j++)
    {
        numb[j] = new Random().Next(1, 100);
    }
}

void PrintArray(double[] numb)
{
    for (int j = 0; j < numb.Length - 1; j++)
    {
        Console.Write(numb[j] + ", ");
    }
    numb[numb.Length-1] = new Random().Next(1, 100);
    Console.WriteLine($"{numb[numb.Length-1]}. ");
    Console.WriteLine();
}

