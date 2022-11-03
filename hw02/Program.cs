/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

Console.WriteLine("введите число");
int n = Convert.ToInt32(Console.ReadLine());
int sum=0 ;
int temp=0;
while(n > 0)
{
        sum = n % 10;
    temp =sum + temp;
    n = n/10;
}
Console.Write("Сумма цифр равна:"+ temp);
