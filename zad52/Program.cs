//int Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArray(int[,] array)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void ProcessingArray(double [] arr,int[,] array)
{
    int rows = array.GetLength(0);
        
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sumrows=0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sumrows+=array[i,j];
            
        }
        arr [j] = Convert.ToDouble(sumrows/rows);
        ///Console.Write(arr[j] + "\t"); 
    }

    
}         

   void PrintArr(double[] array)
{
       for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"Среднее арифметическое столбца {i} = {array[i]}");
       Console.WriteLine(); 
    }
}

Console.Write("Введите количество строк ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int columns = int.Parse(Console.ReadLine());
int [,]array=new int[rows,columns];
double[]arr=new double[columns];
FillArray(array);
ProcessingArray( arr, array);
PrintArray(array);
Console.WriteLine();
PrintArr(arr);