// Задайте двумерный массив. Найдите элементы , у которых оба индекса нечетные и замените эти елементы на их квадтаты 
 // 1 4 7 2         1 4 7 2
 // 5 9 2 3         5 81 2 9
 // 8 4 2 4         8 4 2 4

int[,] FindNumbers(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(i % 2  != 0 && j % 2 != 0)
            {
                array[i,j]  = array[i,j] * array[i,j];
            }
        }
    }
    return array;
}



int[,] GetRandom2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] mass2D = new int[rows, columns];
    FillArray2D(mass2D, minValue, maxValue);
    return mass2D;
    
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


int rows = 4;
int columns = 4;
int minValue = 1;
int maxValue = 7;
int[,] array2D = GetRandom2DArray(rows, columns, minValue, maxValue);
PrintArray2D(array2D);

int[,] array2DAndSquare = FindNumbers(array2D);

PrintArray2D(array2DAndSquare);
