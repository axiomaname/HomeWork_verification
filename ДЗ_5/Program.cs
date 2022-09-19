// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreatRandomArray(int size,int minValue, int maxValue) 

{
int[]newArray=new int[size];
for(int i=0;i<size; i++) // если я хочу идти от начало массива , говорю что i =0 до конца массива увеличивая на 1
newArray[i]=new Random().Next(minValue,maxValue+1);  // предел значения которые элемент может принимать 
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

/*Console.Write("Input size of array: "); // запрос размера массива
int size =Convert.ToInt32(Console.ReadLine());
int min =100;
int max =999;

int[] array= CreatRandomArray(size,min,max);
ShowArray(array);
Console.WriteLine("Count of 3-digit even elements is "+ EvenNumber(array));*/

//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях

int FindSum(int[] array) 
{
    int sum=0;                          
    for(int i=1;i<array.Length;i+=2)    
        sum=sum+array[i];  
    return sum;                      
}

/*Console.Write("Input size of array: "); 
int size=Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input min possible value of elemenrs: "); 
int min=Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of elemenrs: "); 
int max=Convert.ToInt32(Console.ReadLine());

int[] array= CreatRandomArray(size,min,max); 
 ShowArray(array);
Console.WriteLine("Count of elements is " + FindSum(array));*/

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. ( не сделано)