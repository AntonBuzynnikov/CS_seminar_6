// 68. Написать программу, которая обменивает элементы первой строки и последней строки

System.Console.WriteLine("Введите количество строк: ");
int row = Int32.Parse(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов: ");
int column = Int32.Parse(Console.ReadLine());

int[,] array2D = Random2DArray(row,column);
Print2DArray(array2D);
int[,] newArray2D = Cange2DArray(array2D);
System.Console.WriteLine();
Print2DArray(newArray2D);












int[,] Cange2DArray(int[,] arr)
{
    int[,] newArr = new int[arr.GetLength(0),arr.GetLength(1)];
    for(int i = 0; i<newArr.GetLength(0)-1; i++)
    {
        for(int j = 0; j<newArr.GetLength(1);j++)
        {
            if(i == 0)
            {
                newArr[i,j] = arr[arr.GetLength(0)-1,j];
                newArr[newArr.GetLength(0)-1,j] = arr[0,j];
            }
            else
                newArr[i,j] = arr[i,j];
        }
    }
    return newArr;
}

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
            System.Console.Write($"{arr[i,j],9}");
        }
        System.Console.WriteLine();
    }
}

