
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int[] CreateArray(int size) 
{
    int[] newArray =new int[size];  
    Console.WriteLine("Creating array here: ");  
    
    for(int i=0; i< size;i++)               
    {
        Console.Write($"Input {i+1} element: "); 
        newArray[i]=Convert.ToInt32(Console.ReadLine());  
    }
    Console.WriteLine();    
    return newArray;   
}

int PozitivElement(int[] array)
{   
     int count=0;
    for(int i=0; i<array.Length; i++)
        if(array[i]>0)
        count=count+1;
return count;
}

void ShowArray(int[]Array)
{
    for(int i =0; i<Array.Length;i++)
    Console.Write(Array[i]+ " ");
    Console.WriteLine();
}

 /*Console.Write("Input size of array: "); 
int size=Convert.ToInt32(Console.ReadLine());
int[] array=CreateArray(size);
ShowArray(array);
Console.WriteLine("Count of pozitiv elements is " + PozitivElement(array));*/


//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void Intersection(double k1, double b1, double k2, double b2)
{
double x = (b1-b2)/(k2-k1);
double y = (k2*b1-k1*b2)/(k2-k1);
if(k1==k2) 

Console.Write("Линии параллейные");
else
Console.Write($"Точка пересечения заданных прямых: ({x}; {y})");
}
 

/*Console.WriteLine("Input b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Intersection(k1,b1,k2,b2);*/