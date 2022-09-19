//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. 

int [,] CreateRandom2dArray(int rows, int colums,int minValue, int maxValue)
{  int[,] newArray= new int[rows,colums];                                 // для создания нового массива нужна его инициализация
    
    for(int i=0;i<rows;i++)
       
        for(int j=0;j<colums;j++)
        
            newArray[i,j]=new Random().Next(minValue,maxValue+1);                // генерация нового элемента 
            
        Console.WriteLine();
       
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


//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


int [,] CreateRandom2DArray(int n, int m)
 {  int[,] newArray= new int[n,m];                               
    
    for(int i=0;i<newArray.GetLength(0);i++)
        for(int j=0;j<newArray.GetLength(1);j++)
            newArray[i,j]=new Random().Next(0,10+1);               
 return newArray;
 }

int minSumRows(int[,]array)
 {
        int sum =0; int minSum=0;int minSumElem=0;
        
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

/*Console.Write("Input  of rows: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.Write("Input  of colums: ");
int m=Convert.ToInt32(Console.ReadLine());

int [,] myArray= CreateRandom2DArray(n,m);
Show2idArray(myArray);
Console.WriteLine();
Console.WriteLine("Строка с наименьшей суммой номер " + minSumRows(myArray));*/

// Заполните спирально массив 4 на 4.(не выполнено)
