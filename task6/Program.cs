// Задача 4: Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.


int a1 = 44;
int b1 = 5;
int c1 = 78;

int max = a1;
if (b1 > max) max = b1;
if (c1 > max) max = c1;

Console.WriteLine(max);