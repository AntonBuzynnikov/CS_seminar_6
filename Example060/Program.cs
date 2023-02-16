// 60. Показать двумерный массив размером m×n заполненный целыми случайными числами
System.Console.WriteLine("Введите количество строк: ");
int row = Int32.Parse(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов: ");
int column = Int32.Parse(Console.ReadLine());

int[,] array2D = Random2DArray(row,column);
Print2DArray(array2D);








int[,] Random2DArray(int row, int col)
{
    int[,] arr = new int[row,col];
    for(int i = 0; i<arr.GetLength(0); i++)
    {
        for(int j = 0; j<arr.GetLength(1);j++)
        {
            arr[i,j] = new Random().Next(1,51);
        }
    }
    return arr;
}

void Print2DArray(int[,] arr)
{
    for(int i = 0; i<arr.GetLength(0); i++)
    {
        for(int j = 0; j<arr.GetLength(1);j++)
        {
            System.Console.Write($"{arr[i,j],5}");
        }
        System.Console.WriteLine();
    }
}