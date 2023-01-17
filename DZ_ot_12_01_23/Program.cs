// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// Console.WriteLine("Задайте масив ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[N];
// int count = 0;

// FillArray(array);
// PrintArray(array);
// CountArray(array);
// Console.WriteLine(count);

// void CountArray(int[] array)
// {
//     for (int i = 0; i < N; i++)
//     {
// if (array[i] % 2 == 0)
// {
//     count = count + 1;
// }
//     }
// }

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(100, 1000);
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         Console.Write($"{array[i]} ");
//     Console.WriteLine();
// }

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// Console.WriteLine("Задайте масив ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[N];
// int sum1 = 0;

// FillArray(array);
// PrintArray(array);
// SumArray(array);

// Console.WriteLine($"сумма нечетных позиций {sum1}");

// void SumArray(int[] array)
// {
//     for (int i = 1; i < N; i = i + 2)
//     {
//         sum1 = sum1 + array[i];
//     }
// }
// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-1000, 1000);
// }
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         Console.Write($"{array[i]} ");
//     Console.WriteLine();
// }



//Создание объекта для генерации чисел
// Random rnd = new Random();

// //Получить случайное число (в диапазоне от 0 до 10)
// int value = rnd.Next(0, 10);

// //Вывод числа в консоль
// Console.WriteLine(value); 

//------------------------------------------------------------------------------------

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// double[] array = new double[20];
//             Random rand = new Random();
//             for (int i = 0; i < array.Length; i++)
//             {
//                 array[i] = 5 - rand.Next(11) + rand.NextDouble();
//             }

//             Console.ReadLine();
Console.WriteLine("Введите длину массива");
int N = Convert.ToInt32(Console.ReadLine());
double[] array = new double[N];
double min = 10;
double max = -10;

FillArray(array);
S(array);
PrintArray(array);
ResultMin(array);
ResultMax(array);

double sum = max - (min* (-1));
Console.WriteLine($"Разницу между максимальным и минимальным {sum: 0.00}");

void ResultMin(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    Console.WriteLine($"Минимальное значение {min: 0.00}");
}

void ResultMax(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }
    Console.WriteLine($"Максимальное значение {max: 0.00}");
}

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().NextDouble(); //NextDouble

}

void S(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] + (new Random().Next(-10, 11));
    }
}

void PrintArray(double[] array)

{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]: 0.00} ");
    Console.WriteLine();
}