/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
*/
Console.Write ("Inrut a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Inrut a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 <= num2)
{
    Console.WriteLine("Max = " + num2);
}
else
{
    Console.WriteLine("Max = " + num1);
}
/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
*/
Console.Write ("Inrut a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Inrut a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Inrut a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (max <= num2)
{
    max = num2;
}
if (max <= num3)
{
    max = num3;
}
Console.WriteLine(max);
/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
*/
Console.Write ("Inrut a number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
*/
Console.Write("Inrut a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int evenNumber = 2;
if (number >= 2)
{
    while (evenNumber <= number)
    {
        Console.Write(evenNumber + " ");
        evenNumber = evenNumber + 2;
    }
}