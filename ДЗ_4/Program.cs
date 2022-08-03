//=========Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*int FindSum (int a) 
{
    int sum =0; 
    while(a>0)
    {   
        sum=sum+a%10;
        a=a/10;
  
    }
    return sum;
}
    
Console.WriteLine("Input positive num: ");
int num=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of numbers  {num} is {FindSum(num)}"); */

// ======Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

void ArrayElem(int num) //определим массив
{
     int[] array = new int[num];    
    
    int index=0;
    while(index<num)
    {
        array[index]=new Random().Next(1,10);
        Console.Write(" ");
        Console.Write(array[index]);
        index++;
    }
        
}

Console.Write("Imput:  ");
int m = Convert.ToInt32(Console.ReadLine());
ArrayElem(m);