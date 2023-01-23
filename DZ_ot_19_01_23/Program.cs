// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// Console.WriteLine("Введите натуральное  число"); 
// int N = Convert.ToInt32(Console.ReadLine()); 
// Console.Write(Num(N)); 

// string Num(int N) 
// { 
//     if (N==1) return $"1"; 
//     return  $"{N} " + Num(N-1); 
// }


//-----------------------------------------------------

// Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Введите натуральное число min");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите натуральное число max");
// int max = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Num(min, max));

//  int Num(int min, int max)
// {
//     if (min == max ) return max;
//     return min + Num(min + 1, max );
// }

//  int Num(int min, int max)
// {
//     if (max == min ) return min;
//     return max + Num(min, max - 1 );
// }

//-----------------------------------------------------------------

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("Введите натуральное число m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число n");
int n = Convert.ToInt32(Console.ReadLine());

 int Ak(int n, int m)
{
    if (n == 0) return m + 1;
    else
      if ((n != 0) && (m == 0)) return Ak(n - 1, 1);
    else
        return Ak(n - 1, Ak(n, m - 1));
}
 
Console.WriteLine(Ak(m, n)); 


