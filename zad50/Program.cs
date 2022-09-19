// Задача 50. Напишите программу, 
//которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, 
//что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

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

void FindElement(int [,]array,int rows,int columns)
{
    int newrows = array.GetLength(0);
    int newcolumns = array.GetLength(1); 
    if (rows < newrows && columns < newcolumns)
    {
        Console.Write($"Элемент с индексами {rows},{columns} = {array[rows,columns]}");
    }
    else
    {
        Console.Write($"Элемента с индексами {rows},{columns} нет в массиве");
    }
}   

int [,]array=new int[5,6];
Console.Write("Введите номер строки ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите номер столбца ");
int columns = int.Parse(Console.ReadLine());
FillArray(array);
PrintArray(array);
FindElement(array,rows,columns);