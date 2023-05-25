

int MainDiagonalSum(int[,] array)
{
    int mainDiagonalSum = 0;
    int mainDiagonalLength = 0;
    if(array.GetLength(0) > array.GetLength(1))
    {
        mainDiagonalLength = array.GetLength(1);
    }
    else
    {
        mainDiagonalLength = array.GetLength(0);
    }
    for(int i = 0; i < mainDiagonalLength; i++)
    {
        mainDiagonalSum += array[i, i];
    }
    return mainDiagonalSum;
}

void FillArray2D(int[,] array, int minValue, int maxValue)
{
    Random randomDigit = new Random();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = randomDigit.Next(minValue, maxValue +1);
        }
    }
}

int[,] GetRandom2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] mass2D = new int[rows, columns];
    FillArray2D(mass2D, minValue, maxValue);
    return mass2D;
    
}

void PrintArray2D(int[,] array)    // метод печати двумергного  массива 
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int rows = 20;
int columns = 25;
int minValue = 1;
int maxValue = 7;


int[,] array = GetRandom2DArray(rows, columns, minValue, maxValue);
PrintArray2D(array);
Console.WriteLine(MainDiagonalSum(array));