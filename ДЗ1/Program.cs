// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/* int a, b;

Console.Write("Введите первое число: ");
a=Convert.ToInt32(Console.ReadLine());
 
Console.Write("Введите второе число: ");
b= Convert.ToInt32(Console.ReadLine());

if(a>b)
{
    Console.WriteLine("Максимальное число равно " + a);
}
if(b>a)
{
    Console.WriteLine("Максимальное число равно " + b);
}
if(a<b)
{
    Console.WriteLine("Минимальное число равно " + a);
}
if(b<a)
{
    Console.WriteLine("Минимальное число равно " + b);
}
if(a==b)
{
    Console.WriteLine("Числа равназначны");
}
*/

// Задача № 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/* int a, b, c, max;

Console.Write("Введите первое число: ");
a=Convert.ToInt32(Console.ReadLine());
 
Console.Write("Введите второе число: ");
b= Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
c=Convert.ToInt32(Console.ReadLine());

max=a;

if(b>max)
{
    max=b;
}
if(c>max)
{
    max=c;
}

Console.WriteLine("Максимальное число равно " + max);
*/

// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/* int num;

Console.Write("Введите число: ");
num=Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
{
    Console.Write("Число четное");
}
else 
{
    Console.Write("Число нечетное");
} 
*/

// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int n, current;

Console.Write("Введите первое число: ");

n=Convert.ToInt32(Console.ReadLine());
current=2;

 while(current <=n)
 {
    Console.Write(current + " ");
    current= current+2;
 }
 