// Задача 4: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите три числа");
int arg1 = Convert.ToInt32(Console.ReadLine());
int arg2 = Convert.ToInt32(Console.ReadLine());
int arg3 = Convert.ToInt32(Console.ReadLine());
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
//               0   1   2
int[] array = { arg1 , arg2 , arg3 };

int result = Max(array[0], array[1], array[2]);
Console.WriteLine(result);

