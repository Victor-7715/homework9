// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите номер дня недели");
int numberWeek = int.Parse(Console.ReadLine());


// if(numberWeek<1 || numberWeek>7); 
//     {
//         Console.WriteLine (" error");
//     }
// if (numberWeek == 1)
// {
//     Console.WriteLine(" Mondey");
// }
// if (numberWeek == 2)
// {
//     Console.WriteLine(" Tuesday");
// }
// if (numberWeek == 3)
// {
//     Console.WriteLine(" Wensday");
// }
// if (numberWeek == 4)
// {
//     Console.WriteLine(" Thursday");
// }
// if (numberWeek == 5)
// {
//     Console.WriteLine(" Friday");
// }
// if (numberWeek == 6)
// {
//     Console.WriteLine(" Saturday");
// }
// if (numberWeek == 7)
// {
//     Console.WriteLine(" Sunday");
// }


Console.Write("Введите номер дня недели");
int a = int.Parse(Console.ReadLine());
// if (a > 0 && a < 8)
switch (a)
{
    case 1: 
    Console.WriteLine("Понедельник");
    break;
    case 2: 
    Console.WriteLine("Вторник");
    break;
    case 3: 
    Console.WriteLine("Среда");
    break;
    case 4: 
    Console.WriteLine("Четверг");
    break;
    case 5: 
    Console.WriteLine("Пятница");
    break;
    case 6: 
    Console.WriteLine("Суббота");
    break;
    case 7: 
    Console.WriteLine("Воскресенье");
    break;
    default: 
    Console.WriteLine("Ошибка");
    break;
}