// задайте двумерный массив размером m*n, заполненный случайными целыми числами.
// m = 3
// n = 4
// 387, 48, - 43, 0
// 84, 2, 987, -97
// 47,-576, 57, 34

/*
int[,] GetArray2D(int rows, int columns) // int minValue, int maxValue)   // метод создания двумерного массива. 
{
    int[,] array = new int[rows, columns];

    int digit = 1;
    int numberRows = 1;
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            int number = Prompt($"Введите {digit} цифру, {numberRows} строки: ");
            array[i, j] = number;                           //rnd.Next(minValue, maxValue + 1);
            digit++;
        }
        digit = 1;
        numberRows+=1;
    }
    return array;
}
*/


int Prompt(string massage)
{
    System.Console.Write(massage);
    string stringInput = System.Console.ReadLine()!;
    int result = Int32.Parse(stringInput);
    return result;
}

int[,] GetArray2D(int rows, int columns) // int minValue, int maxValue)   // метод создания двумерного массива. 
{
    int[,] array = new int[rows, columns];
    FillArray2D(array);
    return array;
}

void FillArray2D(int[,] array)    // так как мы ни чего не отдаем , значит void , за аргумент берем уже созданный массив,
{                                 // не тот что создали , а просто любой(int[,] array - аргумент, любой массив , который укажем при вызове метода)
    int digit = 1;             
    int numberRows = 1;
    for(int i = 0; i < array.GetLength(0); i++) // запрашиваем встроенный метод вызова длинны строки
    {
        for(int j = 0; j < array.GetLength(1); j++)  // запрашиваем встроенный метод вызова количества столбцов
        {
            int number = Prompt($"Введите {digit} цифру, {numberRows} строки: ");
            array[i, j] = number;                  
            digit++;
        }
        digit = 1;
        numberRows+=1;           
    }
    // выяснили что возврощать ни чего не будем, будем перезаписывать только (void, понял)
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

int rows = Prompt($"Введите колличество строк массива: ");       // чтобы не париться напишем универсальную штуку под разные массивы 2d 
int columns = Prompt($"Введите колличество столбцов массива: "); // где будем сами каждый раз указывать сколько строк и стобцов нужно для памяти 
int[,] array2D = GetArray2D(rows, columns);                      // создали 
PrintArray2D(array2D);                                          // печать
//FillArray2D(array2D);                                           // перезапись имеющегося массива
//PrintArray2D(array2D);                                          // снова печать 