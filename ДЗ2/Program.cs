/*int number2()

{
    int num;
    Console.WriteLine("Введите трехзначное число ");
    num = Convert.ToInt32(Console.ReadLine());

    if(num > 99 && num < 1000)

    Console.WriteLine(num);
    int sotni = num / 100;
    int ed = num / 10;
    int num2 = ed % 10;
    return num2;
}

int number = number2();
Console.WriteLine("Result number is " + number);
*/

// ==== Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


/* void number3()

{
    int num;
    Console.WriteLine("Введите число ");
    num = Convert.ToInt32(Console.ReadLine());

    if (num > 99)
    {
        Console.WriteLine(num);
        int sotni = num % 10;
        Console.WriteLine(sotni);
    }
    if (num < 99)
    {
        Console.WriteLine("Третьей цифры нет");
    }
}
number3();*/


// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int nedelka()
{


    int day;
    Console .Write("Введите  номер недели от 1 до 7: ");
    day=Convert.ToInt32(Console.ReadLine());


    if(day ==1)
    {
        Console.Write("Понедельник");

    }
    if(day ==2)
    {
        Console.Write("Вторник");
    }
    if(day==3)
    {
        Console.Write("Среда");
    }
    if(day==4)
    {
        Console.Write("Четверг");
    }
    if(day==5)
    {
        Console.Write("Пятница");
    }
    if(day == 6)
    {
        Console.Write("Cуббота- выходной");
    }
    if(day==7)
    {
        Console.Write("Воскресенье -выходной");
    }
    if(day>7 || day < 1)
    {
        Console.Write("Введите число от 1-7");
    }

    
    if(day >0 && day <6)
    {
        Console.Write("Рабочий день");
    }

    return day;
}
int ned = nedelka();
