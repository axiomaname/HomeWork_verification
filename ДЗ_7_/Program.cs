// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

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
            for(int j = 0;j<array.GetLength(1);j++)                                                    
                Console.Write(array[i,j]+ " ");
        }    
   }  

/*Console.Write("Input number of rows: ");  
int m=Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colums: ");
int n=Convert.ToInt32(Console.ReadLine());
                                 
double[,] myArray=CreateRandomDouble2DArray(m,n);
Show2dArray(myArray); */

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int [,] CreateRandom2DArray(int n, int m)
 {  int[,] newArray= new int[n,m];                               
    
    for(int i=0;i<newArray.GetLength(0);i++)
        for(int j=0;j<newArray.GetLength(1);j++)
            newArray[i,j]=new Random().Next(0,10+1);               
 return newArray;
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

/*Console.Write("Input  of rows: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.Write("Input  of colums: ");
int m=Convert.ToInt32(Console.ReadLine());

int [,] myArray= CreateRandom2DArray(n,m);
Show2idArray(myArray);
FindElement(myArray,n,m);*/

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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

Console.Write("Input  of rows: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.Write("Input  of colums: ");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine ();
int [,] myArray= CreateRandom2DArray(n,m);
Show2idArray(myArray);
Console.WriteLine ("Среднее арифметическое значение по столбцам: ");
ArithmeticMeadRow(myArray);

