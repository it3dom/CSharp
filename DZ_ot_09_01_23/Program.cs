// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Console.WriteLine("!ввод 5-ти значного числа ! ");
// int N = Convert.ToInt32(Console.ReadLine());

// int x5 = N % 10;
// int y5 = N % 100;
// int x4 = y5 / 10;

// int x1 = N / 10000;
// int y2 = N / 1000;
// int x2 = y2 % 10;

// if (x1 == x5 && x2 == x4)
// {
//     Console.WriteLine($"{N} -> да,число является полиндромом");
// }
// else
// {
//     Console.WriteLine($"{N} -> нет,число не является полиндромом");
// }

// Console.WriteLine("вв н");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(string.Concat($"{n}".Reverse())); // разворот числа



//-----------------------------------------------------------



// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координаты точек:");

// Console.WriteLine("Введите х1:");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y1:");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите z1:");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите x2:");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y2:");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите z2:");
// int z2 = Convert.ToInt32(Console.ReadLine());

// int d1 = (x2-x1)*(x2-x1);
// int d2 = (y2-y1)*(y2-y1);
// int d3 = (z2-z1)*(z2-z1);

// double d = Math.Sqrt(d1+d2+d3); //квадратный корень

// Console.WriteLine("Расстояние между точками равно " + Math.Round(d, 2)); // кол-во знаков после запятой 

// int n = 10;
// int i = 2;
//     Console.Write(Math.Pow(n,i)); возведение в степерь n - число i - степень
//----------------------------------------------------------------------------------------


// Задача 23

// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

//  Console.WriteLine("Введите N:");
//  int N=Convert.ToInt32(Console.ReadLine());
 
//  for(int i=1;i<=N;i++)
//  {
//         Console.Write(i*i*i);
//         Console.Write(" ");
//  }

