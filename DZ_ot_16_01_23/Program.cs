// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// double[,] array = new double[rows, cols];

// S(array);
// FillArray(array);
// PrintArray(array);

// void S(double[,] array)

// {

//     for (int m = 0; m < rows; m++)         
//     for (int i = 0; i < array.GetLength(0); i++)
//         array[i,m] = new Random().NextDouble();

//     for (int n = 0; n < cols; n++)
//     for (int j = 0; j < array.GetLength(1); j++)
//         array[n,j] = new Random().NextDouble();

// }

// void FillArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//             for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = array[i,j] + (new Random().Next(-10, 11));
//        }

// void PrintArray(double[,] array)


// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{+ Math.Round(array[i, j],1)} \t");
//         Console.WriteLine();
//     }
// }

//--------------------------------------------------------------------------------------

// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.WriteLine("Введите количество столбцов");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, cols];
// Console.WriteLine("Число ");
// int N = Convert.ToInt32(Console.ReadLine());

// FillArray(array);
// PrintArray(array);
// SearchArray(array, N);

//  void SearchArray(int[,] array, int N)
// {
//     //bool find = false; // Флажок - индикатор поиска переменной в нашем массиве
//     string find = String.Empty;
//     string text1 = "Число есть ";
//     string text2 = "Числа нет ";
//     find = text2;
//      for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (N == array[i, j])
//             {
//                 find = text1;
//                 break;
//             }
//         }
//     Console.WriteLine(find);
// }

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(0, 21);
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j],3} \t");
//         Console.WriteLine();
//     }
// }


//---------------------------------------------------------------------------------------------------------


// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];

FillArray(array);
PrintArray(array);

for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    
    Console.Write($"{ sum / rows : 0.0} \t ");
}


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-10, 11);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3} \t");
        Console.WriteLine();
    }
}





