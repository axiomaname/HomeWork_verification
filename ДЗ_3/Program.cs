// ====== * Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.*

/*  void Palindrom()

{   int num;
    Console.Write("Input number: ");
    num=Convert.ToInt32(Console.ReadLine());
    
    if(num>=10000 && num<=99999)
    Console.WriteLine(num);
 
    int one=num/10000; Console.WriteLine(one);
    int two=num /1000 %10;Console.WriteLine(two);
    int three=num /100;Console.WriteLine(three);
    int four=three / 10 %10 ;Console.WriteLine(four);
    int five=num %10;Console.WriteLine(five);

     if(one == five && two == four) Console.WriteLine("Число явяется палиндромом");

    else
    Console.WriteLine("Число НЕ явяется палиндромом");
}
Palindrom();  */

// =====* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*void Kubn(int n)
{
    int current =1;
    while(current <=n)
    {
         int kub =current*current*current;
         Console.Write(kub + " ");
         current++;
    }

}

Console.Write("Input number: ");
int numN =Convert.ToInt32(Console.ReadLine());
Kubn(numN); */