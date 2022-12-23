// ЗАДАЧА Семинара, выведение в одну строку
// Напишите программу, которая принимает 
// на вход число (N) и выдаёт таблицу 
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.WriteLine ("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write(num);

// for (int i=1; i<=num; i++)
// {
//     Console.Write(","+i*i);
// }

// __________________________________________________________________________________
// ЗАДАЧА 1
// Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите пятизначное число");
// string num = Convert.ToString (Console.ReadLine());

// if (num.Length==5)
// {
//     if (num[0]==num[4] && num[1] == num[3])
//     {
//         Console.WriteLine("Число является палиндромом");
//     }
//     else
//     {
//         Console.WriteLine("Число не является палиндромом");
//     }
// }
// else
// {
//     Console.WriteLine("Число не пятизначное");
// }

// ___________________________________________________________
// ЗАДАЧА 2
// Напишите программу, которая принимает 
// на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine ("Введите X для точки 1");
// int X1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите Y для точки 1");
// int Y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите Z для точки 1");
// int Z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine ("Введите X для точки 2");
// int X2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите Y для точки 2");
// int Y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите Z для точки 2");
// int Z2 = Convert.ToInt32(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow((X2-X1),2)+Math.Pow((Y2-Y1),2)+Math.Pow((Z2-Z1),2));
// Console.WriteLine(d);

// ____________________________________________________________________
// ЗАДАЧА 3
// Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine ("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write(num);

for (int i=1; i<=num; i++)
{
    Console.Write(","+i*i*i);
}