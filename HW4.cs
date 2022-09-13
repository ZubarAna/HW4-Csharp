/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

/*
Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write(Math.Pow(n, m) + " ");
*/

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

/*
Console.Write("Ведите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int s = 0;

while(n > 0)
{
    s += n % 10;;
    n = n / 10;
}
    Console.Write(s);
*/

/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]*/

int [] array = new int [8];
for(int i = 0; i < array.Length; i++)
{
    Console.Write("Введите " + i + "-й элемент: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("[" + string.Join(",", array) + "]");