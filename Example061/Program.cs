// 61. Показать двумерный массив размером m×n заполненный вещественными случайными числами

System.Console.WriteLine("Введите количество строк: ");
int row = Int32.Parse(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов: ");
int column = Int32.Parse(Console.ReadLine());

double[,] array2D = Random2DArray(row,column);
Print2DArray(array2D);








double[,] Random2DArray(int row, int col)
{
    double[,] arr = new double[row,col];
    for(int i = 0; i<arr.GetLength(0); i++)
    {
        for(int j = 0; j<arr.GetLength(1);j++)
        {
            arr[i,j] = new Random().NextDouble();
        }
    }
    return arr;
}

void Print2DArray(double[,] arr)
{
    for(int i = 0; i<arr.GetLength(0); i++)
    {
        for(int j = 0; j<arr.GetLength(1);j++)
        {
            System.Console.Write($"{arr[i,j],6:F2}");
        }
        System.Console.WriteLine();
    }
}