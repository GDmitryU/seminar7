//Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

void FillArray(double [,] inArray, int m, int n)
{

for (int i = 0; i < m; i++)
{
for (int j = 0; j < n; j++)
{
 Random rand = new Random();
            //double random = (double)rand.NextDouble();
            inArray[i,j] = Math.Round((rand.NextDouble() * 22),1);                 
}
}
}
void PrintArray(double[,] outArray)
{
for (int i = 0; i < outArray.GetLength(0); i++)
{
for (int j = 0; j < outArray.GetLength(1); j++)
{
Console.Write(string.Format("  {0:n}  ",outArray[i, j] ));
}
Console.WriteLine();
}
}

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
double[,] inArray = new double[rows, columns];
    FillArray (inArray, rows, columns);
    PrintArray (inArray);


