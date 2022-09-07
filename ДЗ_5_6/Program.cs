
int[] CreatRandomArray(int size,int minValue, int maxValue) 

{
int[]newArray=new int[size];
for(int i=0;i<size; i++) // если я хочу идти от начало массива , говорю что i =0 до конца массива увеличивая на 1
newArray[i]=new Random().Next(minValue,maxValue+1);  // предел значения которые элемент может принимать 
return newArray;
}

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

int EvenNumber(int[] array)
 
{
int count=0;
for(int i =0; i<array.Length; i+=2)
if(array[i] %2 ==0 )count++;

return count;
}

void ShowArray(int[]Array)
{
    for(int i =0; i<Array.Length;i++)
    Console.Write(Array[i]+ " ");
    Console.WriteLine();
}

int PozitivElement(int[] array)
{   
     int count=0;
    for(int i=0; i<array.Length; i++)
        if(array[i]>0)
        count=count+1;
return count;
}

int FindSum(int[] array) 
{
    int sum=0;                          
    for(int i=1;i<array.Length;i+=2)    
        sum=sum+array[i];  
    return sum;                      
}

void Intersection(double k1, double b1, double k2, double b2)
{
double x = (b1-b2)/(k2-k1);
double y = (k2*b1-k1*b2)/(k2-k1);
if(k1==k2) 

Console.Write("Линии параллейные");
else
Console.Write($"Точка пересечения заданных прямых: ({x}; {y})");
}

double[,] CreateRandomDouble2DArray(int rows, int colums)
 { 
     double[,] newArray= new double[rows,colums];                                 // для создания нового массива нужна его инициализация
   
    for(int i=0;i<newArray.GetLength(0);i++)
       {
         for(int j=0;j<newArray.GetLength(1);j++)
           {
           newArray[i,j]=new Random().NextDouble()*10;         // генерация нового элемента  *10 , тк изначально .NextDouble() от 0-1
           }
        Console.WriteLine();
       }
 return newArray;
 }

void Show2dArray(double[,] array)                                                    
   {
        for(int i=0;i<array.GetLength(0);i++)
        { 
            for(int j = 0;j<array.GetLength(1);j++)                                                    // Проход по всем элементам чтобы вывести все
                Console.Write(array[i,j]+ " ");
        }    
   }         

void Show2idArray(int[,] array)                                                    
   {
        for(int i=0;i<array.GetLength(0);i++)
        { 
            for(int j = 0;j<array.GetLength(1);j++)                                                    // Проход по всем элементам чтобы вывести все
                Console.Write(array[i,j]+ " ");

        Console.WriteLine();  //должен быть за пределами внуир цикла , но внутри основного . ТАк будет разделять вывод информации после завершения цикла
        }    
   }       

int [,] CreateRandom2DArray(int n, int m)
 {  int[,] newArray= new int[n,m];                               
    
    for(int i=0;i<newArray.GetLength(0);i++)
        for(int j=0;j<newArray.GetLength(1);j++)
            newArray[i,j]=new Random().Next(0,10+1);               
 return newArray;
 }

int [,] CreateRandom2dArray(int rows, int colums,int minValue, int maxValue)
 {  int[,] newArray= new int[rows,colums];                                 // для создания нового массива нужна его инициализация
    
    for(int i=0;i<rows;i++)
       
        for(int j=0;j<colums;j++)
        
            newArray[i,j]=new Random().Next(minValue,maxValue+1);                // генерация нового элемента 
            
        Console.WriteLine();
       
 return newArray;
 }

void FindElement(int[,]myArray,int rows,int coloms)
{
Console.Write("Input  number index rows: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.Write("Input number index coloms: ");
int m=Convert.ToInt32(Console.ReadLine());

if (n < myArray.GetLength(0) && m < myArray.GetLength(1)) 
    Console.Write($"Значение элемента с индексом [{n}, {m}] = {myArray[n, m]}");
    else
    Console.Write($"В массиве отсутствует элемент c индексом  [{n}, {m}]");
    
}

void ArithmeticMeadRow(int[,] array)
{   
    int count=array.GetLength(0);
    double result=0;
      
    for (int i=0;i<array.GetLength(1);i++)
   { double sum=0;
        for(int j=0;j<array.GetLength(0);j++)
        {
            sum=sum+array[i,j];  
            result=sum/count; 
        }
        Console.WriteLine(sum/count); 
   }
}

int [,]SortedRows(int[,]array)
{
    for(int i=0; i<array.GetLength(0);i++)
        for(int j=0;j<array.GetLength(1)-1;j++)
        {
            if(array[j,i]<array[i,j+1])
            {
                int temp=array[i,j];
                array[i,j]=array[i,j+1];
                array[i,j+1]=temp;

            }
        }
return array;
}

int Number(int n)  //  Реверсия
{
    if(n/10!=0)
        return 1 + Number(n / 10); 
    else
    return 1;
}

int SumElem(int m,int n) //  Реверсия
{
    if (n>m)
    {
        return n +SumElem(m,n-1);
 
    }
     return 0;
}

int minSumRows(int[,]array)

    {
    
        int sum =0;
        int minSum=0;
        int minSumElem=0;
        
        for(int i=0; i<array.GetLength(0);i++)
        {
            for(int j=0;j<array.GetLength(1);j++)
            {
                if (i==0) 
                sum +=array[i,j];
                minSum+=array[i,j];
            }
        
        if (sum<minSum)
            minSum=sum;
            minSumElem=i+1;
        
        }

       /* if(array.GetLength(0)!=array.GetLength(1))
        Console.WriteLine(" Массив не является прямоугольником");*/

    return minSumElem;

    }


// ==== Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
Console.Write("Input size of array: "); // запрос размера массива
int size =Convert.ToInt32(Console.ReadLine());
int min =100;
int max =999;

int[] array= CreatRandomArray(size,min,max);
ShowArray(array);
Console.WriteLine("Count of 3-digit even elements is "+ EvenNumber(array));
*/

//=== Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*Console.Write("Input size of array: "); 
int size=Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input min possible value of elemenrs: "); 
int min=Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of elemenrs: "); 
int max=Convert.ToInt32(Console.ReadLine());

int[] array= CreatRandomArray(size,min,max); 
 ShowArray(array);
Console.WriteLine("Count of elements is " + FindSum(array));*/

 /*=== Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
Console.Write("Input size of array: "); 
int size=Convert.ToInt32(Console.ReadLine());
int[] array=CreateArray(size);
ShowArray(array);
Console.WriteLine("Count of pozitiv elements is " + PozitivElement(array)); */
 
 //===  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
Console.WriteLine("Input b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Intersection(k1,b1,k2,b2);*/

// ====  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 
/*Console.Write("Input number of rows: ");  
int m=Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colums: ");
int n=Convert.ToInt32(Console.ReadLine());
 
                                 
double[,] myArray=CreateRandomDouble2DArray(m,n);
Show2dArray(myArray);  
*/

//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет
/*Console.Write("Input  of rows: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.Write("Input  of colums: ");
int m=Convert.ToInt32(Console.ReadLine());

int [,] myArray= CreateRandom2DArray(n,m);
Show2idArray(myArray);
FindElement(myArray,n,m); */

// == Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
Console.Write("Input  of rows: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.Write("Input  of colums: ");
int m=Convert.ToInt32(Console.ReadLine());

int [,] myArray= CreateRandom2DArray(n,m);
Show2idArray(myArray);
ArithmeticMeadRow(myArray);*/


// === Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*Console.Write("Input number of rows: ");
int m=Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colums: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min=Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max=Convert.ToInt32(Console.ReadLine());

int[,]myArray=CreateRandom2dArray(m,n,min,max);
Show2idArray(myArray);
Console.WriteLine();
Show2idArray(SortedRows(myArray));*/

// ==  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. (доделать)


/*Console.Write("Input  of rows: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.Write("Input  of colums: ");
int m=Convert.ToInt32(Console.ReadLine());

int [,] myArray= CreateRandom2DArray(n,m);
Show2idArray(myArray);
Console.WriteLine();
Console.WriteLine("Строка с наименьшей суммой номер " + minSumRows(myArray));*/

//==  Заполните спирально массив 4 на 4.(не выполнено)

//==Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N рекурсивным методом.

/*Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(Number(n));*/

// ==  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int Sum=SumElem(m,n);

Console.WriteLine($"Suma = {Sum}");  */


