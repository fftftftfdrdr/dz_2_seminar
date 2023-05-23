// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >=100)
    {
     while (number > 999)
     {
        number = number / 10;
     }
        int result = number % 10;
        System.Console.WriteLine($"Третье число: {result}");
    }
    else
    {
      System.Console.WriteLine($"третьей цифры нет");
    }
 

 
