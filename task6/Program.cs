// Задача 4: Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите число a ");
int a1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b ");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число c ");
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

Console.WriteLine("Максимальное число " + max);