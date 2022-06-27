// dz Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// Console.Write("Введите цифру : ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number<8 && number>0)
// {
//     if (number<6 && number>0)   
//     {

//     Console.Write("нет");
//     }
//  else
//     {
//         Console.Write("да");
//     }

// }

//  Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8 
// 918 -> 1

// int number= new Random().Next(100,1000);
// Console.WriteLine($"Значение : {number}");
// int digit1=number/10%10;

// Console.WriteLine(digit1);

//  Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// 1020 -> 2

// первый способ
// int Number= new Random().Next(10,100000);
// Console.WriteLine($"Значение : {Number}");
// string number=Convert.ToString(Number);
// Console.WriteLine(number[2]);

// второй способ
// string num=Console.ReadLine();
// Console.WriteLine(num[2]);
