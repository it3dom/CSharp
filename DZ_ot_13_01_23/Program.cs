// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


// Console.WriteLine("сколько чисел счить? ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(" ");
// int[] array = new int[M];
// int count = 0;

// FillArray(array);
// VvodArray(array);

// for (int i = 0; i < M; i++)
// {
//    if (array[i] > 0)
//    {
//     count = count + 1; 
//    }
// }

// Console.Write(count);

// void VvodArray(int[] array)

// {
//     for (int i = 0; i < M; i++)
//     {
//         Console.WriteLine("Введите {0}-й элемент", i + 1);
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
// }

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-100, 100);
// }
//------------------------------------------------------------------------------------------




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5

// Console.WriteLine("Ввод b1 ");
// double b1 = Convert.ToInt64(Console.ReadLine());
// Console.WriteLine("Ввод k1 ");
// double k1 = Convert.ToInt64(Console.ReadLine());
// Console.WriteLine("Ввод b2 ");
// double b2 = Convert.ToInt64(Console.ReadLine());
// Console.WriteLine("Ввод k2 ");
// double k2 = Convert.ToInt64(Console.ReadLine());


// double x = (b2 - b1) / (k1 - k2);
// double y = (k2 * b1 - k1 * b2) / (k2 - k1);

// if (x == y)
// {
//     Console.WriteLine(" ");
//     Console.Write($"точка пересечения {x},{y} ");
// }
// else
// {
//     Console.WriteLine(" ");
//     Console.Write($"Пересечения нет, {x}; {y}");
// }
//--------------------------------------------------------------------------------------------------



// задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа. 
// Определить , является ли это сторонами треугольника. 
// Если да, то вывести всю информацию по нему - площадь, периметр, значения углов треугольника в градусах,
//  является ли он прямоугольным, равнобедренным, равносторонним.

// double A = 0.67;
// double gr = Math.Acos(A) * 180 / Math.PI;
// Console.WriteLine(gr);


Console.Write("Первая сторона: ");
double a = Convert.ToInt64(Console.ReadLine());
Console.Write("Вторая сторона: ");
double b = Convert.ToInt64(Console.ReadLine());
Console.Write("Сторона три: ");
double c = Convert.ToInt64(Console.ReadLine());

if (a + b > c && b + c > a && a + c > b)
{
    Console.WriteLine("Да,это треугольник");

double P = a + b + c;
double pol = (a + b + c) / 2;
double S = pol * (pol - a) * (pol - b) * (pol - c);
double s = Math.Sqrt(S);

if (a == b && b == c)  Console.WriteLine("Треугольник равносторонний ");
else if (a == b || b == c || a == c) Console.WriteLine("Треугольник равнобедренный ");

double A = ((b * b) + (c * c) - (a * a)) / (2 * b * c);
double Agr = Math.Acos(A) * 180 / Math.PI;
double B = ((a * a) + (c * c) - (b * b)) / (2 * a * c);
double Bgr = Math.Acos(B) * 180 / Math.PI;
double C = ((a * a) + (b * b) - (c * c)) / (2 * a * b);
double Cgr = Math.Acos(C) * 180 / Math.PI;

if (Agr == 90 || Bgr == 90 || Cgr == 90 ) Console.WriteLine("Треугольник прямоугольный ");

Console.WriteLine($"периметр - {P}, полуперимтр - {pol}, площадь - {s: 0.00} ");
Console.WriteLine($"Угол А:{Agr: 0.00} градусов; Угол Б:{Bgr: 0.00} градусов; Угол С:{Cgr: 0.00} градусов. ");

}
else 
Console.WriteLine(" -Eror-  404 ");
Console.WriteLine(" ");










