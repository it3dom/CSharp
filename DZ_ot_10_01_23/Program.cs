// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
//  возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
// Console.WriteLine("Число ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Степень ");
// int i = Convert.ToInt32(Console.ReadLine());

// Console.Write(Math.Pow(n, i));

// -----------------------ИЛИ ---------------

// Console.WriteLine("Число ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Степень ");
// int s = Convert.ToInt32(Console.ReadLine());

// int x = n;
// for (int i = 1; i < s; i++)
// {
//    x = x*n;
// }
// Console.WriteLine($"{x}");


// -----------------------------------------------------

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Число ");
// int n = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// int i = 0;
//  while (n > 0)
//  {
//     sum = sum + n % 10;
//     n = n / 10;
//     i++;
// }
// Console.WriteLine($"сумма числа {sum}");

//-----------------------------------------------------------------

// Задача 29: Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и
//  далее выводит массив на экран в одну строку

// Console.WriteLine("Введите длину массива");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[N];

// FillArray(array); // создать
// VvodArray(array);  //ввести/изменить
// PrintArray(array); //вывод

// void VvodArray(int[] array)
// {
//     for (int i = 0; i < N; i++)
// {
//     Console.WriteLine("Введите {0}-й элемент", i + 1);
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }
// }

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(0, 100);
// }

// void PrintArray(int[] array)

{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}


