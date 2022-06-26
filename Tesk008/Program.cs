// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число ");
int i = Convert.ToInt32(Console.ReadLine());
int l=2 ;
while(l <= i)
 {
    Console.WriteLine($"{l}");
    l+=2;
 }