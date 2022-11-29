// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

int deep1 = InputInt("Введите размерность 1: ");
int deep2 = InputInt("Введите размерность 2: ");
int deep3 = InputInt("Введите размерность 3: ");
int countNumb = 75;

if (deep1 * deep2 * deep3 > countNumb)
{
    Console.Write("Массив слишком большой");
    return;
}

int[,,]resultNumb = Creat3DMassive (deep1, deep2, deep3);

for (int i = 0; i < resultNumb.GetLength(0); i++)
{
    for (int j = 0; j < resultNumb.GetLength(1); j++)
    {
        for (int k = 0; k < resultNumb.GetLength(2); k++)
        {
            Console.WriteLine($"[{i},{j},{k}] - {resultNumb[i,j,k]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,,]Creat3DMassive (int size1, int size2, int size3)
{
    int[,,] array = new int[size1,size2,size3];
    int[] value = new int[countNumb];
    int num = 10;
    for (int i = 0; i < value.Length; i++)
    {
        value[i] = num;
        num++;
    }
    
    for (int i = 0; i < value.Length; i++)
    {
        int randomInd = new Random().Next(0,value.Length);
        int temp = value[i];
        value[i] = value[randomInd];
        value[randomInd] = temp;
    }

    int valueIndex = 0;
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i,j,k] = value[valueIndex++];
            }
        }
    }
    return array;
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}