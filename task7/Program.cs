// Задача 6: Напишите программу, которая на вход
// принимает число и выдаёт, является ли число чётным
// (делится ли оно на два без остатка).

Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 1)
{
    Console.WriteLine("Число является Нечетным ");
}
else
{
    Console.WriteLine("Число является Четным ");
}
