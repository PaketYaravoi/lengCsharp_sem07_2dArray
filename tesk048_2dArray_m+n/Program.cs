// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] GetArray2D(int rows, int columns)
{
    int[,] array = new int[rows, columns];
   // int m = 0;
    //int n = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = i+j; //m + n ;
           // m+=1;
        }
        //m = 0;
        //n+=1;

    }
    return array;
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

int rows = 3;
int columns = 4;
int[,] array = GetArray2D(rows, columns);
PrintArray2D(array);
                
            




