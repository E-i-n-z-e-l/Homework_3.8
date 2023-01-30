// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine(string.Empty);
int [,] disOrderedMatrix = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(disOrderedMatrix);
Console.WriteLine(string.Empty);
int [] newArray = NewMatrixSumRows(disOrderedMatrix);
PrintArray(newArray);
Console.WriteLine(string.Empty);
Console.WriteLine(string.Empty);
int minSumElements = MinSumElementRows(newArray);
Console.WriteLine($"{minSumElements} => минимальная сумма элементов строки среди строк в двумерном массиве");
int indexOff = MinIndexElementRows(newArray, minSumElements);
Console.Write($"{indexOff} => номер строки в котором минимальная сумма элементов среди всех строк"); // Именно номер, а не индекс строки;
Console.WriteLine(string.Empty);
Console.WriteLine(string.Empty);

int [,] CreateMatrixRndInt(int rows, int columns, int min, int max) 
{
	int[,] matrix = new int[rows, columns];
	Random rnd = new Random();

	for (int i = 0; i < matrix.GetLength(0); i++) 
	{
		for (int j = 0; j < matrix.GetLength(1); j++) 
		{
			matrix[i, j] = rnd.Next(min, max + 1);
		}
	}
	return matrix;
}

void PrintMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		Console.Write("[");
		for (int j = 0; j < matrix.GetLength(1); j++)
		{	
			if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
			else Console.Write($"{matrix[i, j], 4} ");
		}	
		Console.WriteLine("]");
    }
}


int [] NewMatrixSumRows (int [,] matrix)
{
    int [] array = new int[matrix.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            sum = sum + matrix[i,j];
        }
        int sumRows = sum;
        array[i] = sumRows;
    }
    return array;
}


void PrintArray(int[] arr)
{
    Console.Write("[   ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",   ");
        else Console.Write(arr[i]);
    }
    Console.Write(" ]");
}

int MinSumElementRows(int[] arr)
{
    int indexMinElement = 0;
    int minElement = arr[indexMinElement];
    for (indexMinElement = 0; indexMinElement < arr.Length; indexMinElement++)
    {
        if (arr[indexMinElement] < minElement) minElement = arr[indexMinElement];
    }
    return minElement;
}

int MinIndexElementRows (int [] array, int value)
{
    int i = 0;
    for (i = 0; i < array.Length; i++)
    {
        if (array[i] == value) return i + 1; // Именно номер, а не индекс строки;
    }
    return i + 1; // Именно номер, а не индекс строки;
}







