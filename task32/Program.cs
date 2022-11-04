//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива ");
int size = int.Parse(Console.ReadLine());
int[] numb = new int[size];
FillArray(numb);
PrintArray(numb);
int sum = 0;

for (int i = 1; i < numb.Length;)
{
    sum = sum + numb[i];
    i = i+2;
}

Console.WriteLine($"Сумма элементов на нечетных позициях {sum}");

void FillArray(int[]numb)
{
    for (int i = 0; i < numb.Length; i++)
    {
        numb[i] = new Random().Next(-10, 10);
    }
}

void PrintArray(int[]numb)
{
    for (int i = 0; i < numb.Length; i++)
    {
        Console.Write(numb[i]+ " ");
    }
}