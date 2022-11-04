// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массив ");
int size = int.Parse(Console.ReadLine());
int[] numb = new int[size];
FillArray(numb);
PrintArray(numb);
int count = 0;

for (int j = 0; j < numb.Length; j++)
{
    if (numb[j] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество четных чисел {count}. ");

void FillArray(int[] numb)
{
    for (int i = 0; i < numb.Length; i++)
    {
        numb[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] numb)
{
    for (int i = 0; i < numb.Length - 1; i++)
    {
        Console.Write(numb[i] + ", ");
    }
    numb[numb.Length-1] = new Random().Next(100, 1000);
    Console.WriteLine($"{numb[numb.Length-1]}. ");
    Console.WriteLine();
}