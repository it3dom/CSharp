
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите первое число ");
// int  x = Convert.ToInt32 ( Console.ReadLine());
// Console.WriteLine(" Введите второе число ");
//  int y = Convert.ToInt32(Console.ReadLine());
//  if (x > y)
//  {
//     Console.WriteLine("первое число больше второго ");
//     Console.WriteLine($"MAX = {x}, MIN = {y} ");
//  }
//  else 
//  {
//     Console.WriteLine("второе число больше первого");
//     Console.WriteLine($"NAX = {y}, MIN = {x} ");
//  }
//------------------------------------------------------------------------
// Задача 4: Напишите программу,
// которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


// Console.WriteLine("Введите первое число ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(" Введите второе число ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(" Введите третье число ");
// int c = Convert.ToInt32(Console.ReadLine());

// int max = a;
// if (max < b)
// {
//     max = b;
// }
// if (max < c)
// {
//     max = c;
// }
// Console.WriteLine("максимальное число = " + max);
//------------------------------------------------------------------


// Задача 6: Напишите программу, 
// которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет
// Console.WriteLine ("Введите число ");
// int x = Convert.ToInt32(Console.ReadLine());
// if (x % 2 == 0)
// {
//     Console.WriteLine ("Четное ");
//     }
// else
// {
//     Console.WriteLine("Не Четное");
// }
//-------------------------------------------------------------------


// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
//-----------------------------------------------------
//  Console.WriteLine ("Введите число ");
//   int N = Convert.ToInt32(Console.ReadLine());

// void FillArray(int[] N)
// {
//     int length = N.Length;
//     int index = 0;
//     while (index < length)
//     {
//      N[index] = (1);
//      index++;   
//     }
//  }
// void PrintArray(int[] N1)
// {
//     int count = N1.Length;
//     int index1 = 0;
//     while (index1 < count)
//     {
//         Console.Write(N1[index1]);
//         index1++;
//     }
// }
// int[] array = new int[10];

// FillArray(array);
// PrintArray(array);
//----------------------------------------------