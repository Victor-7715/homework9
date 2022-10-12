// Задача 4: Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите число ");
int a1 = int.Parse(Console.ReadLine());
int b1 = int.Parse(Console.ReadLine());
int c1 = int.Parse(Console.ReadLine());

int max = a1;
if (b1 > max) 
{
    max = b1;
}
if (c1 > max)
{
    max = c1;
} 

Console.WriteLine(max);