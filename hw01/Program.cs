/*  Напишите метод, который принимает на вход два числа (A и B) и возводит число A в целую степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

без использования math.pow */
Console.WriteLine("введите первое числов");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите 2 число");
int b = Convert.ToInt32(Console.ReadLine());
 int result = 1;
 for (int i = 1; i <= b; i++)
    {
 result = result * a;
    }
 Console.WriteLine(result);
 

