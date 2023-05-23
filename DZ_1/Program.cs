// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int x1 = num / 100; 
int x2 = num % 10;
int supernum = (100 * x1 + x2);
int x3 = ((num - supernum) / 10 );
System.Console.WriteLine($"Ваше число: {x3}");