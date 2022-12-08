// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

// void Palindrom()
// {
//     int n = new Random().Next(10000, 100000);
//     Console.WriteLine(n);
//     int n1 = n/10000;
//     int n2 = n/1000%10;
//     int n4 = n/10%10;
//     int n5 = n%10;
//     if (n1 == n5 & n2 == n4)
//     {
//         Console.WriteLine("Palindrom");
//     }
//     else 
//     {
//         Console.WriteLine("Not palindrom");
//     }
// }
//
// Palindrom();

// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 3D пространстве.


// double Distance(int x1, int x2, int y1, int y2, int z1, int z2)
// {
//     int f = (x2-x1)*(x2-x1);
//     int f1 = (y2-y1)*(y2-y1);
//     int f2 = (z2-z1)*(z2-z1);
//     double result = Math.Sqrt(f+f1+f2);
//     return result;
// }

// Console.WriteLine("enter x1");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("enter x2");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("enter y1");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("enter y2");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("enter z1");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("enter z2");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double res = Distance(x1, x2, y1, y2, z1, z2);
// Console.WriteLine($"result- {Math.Round(res,2)}");


// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// void Cube(int N)
// {
//     int count = 1;
//     while (count <= N)
//     {
//         int cub = count*count*count;
//         Console.WriteLine($"{cub} " );
//         count++;
//     }
// }

// Console.WriteLine("Enter number");
// int N = Convert.ToInt32(Console.ReadLine());

// Cube(N);
