// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int [,] firstMatrix = CreateMatrixRndInt(3, 2, 2, 4);
int [,] secondMatrix = CreateMatrixRndInt(2, 3, 2, 4);
PrintMatrix(firstMatrix);
Console.WriteLine(string.Empty);
Console.WriteLine(string.Empty);
PrintMatrix(secondMatrix);
Console.WriteLine(string.Empty);
Console.WriteLine(string.Empty);
if (firstMatrix.GetLength(1) == secondMatrix.GetLength(0))
{int [,] newMatrix = NewMatrixFirstSecond(firstMatrix, secondMatrix);
PrintMatrix(newMatrix);
}
else Console.WriteLine($"Число столбцов первой матрицы не совпадает с числом строк второй матрицы");
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

int [,] NewMatrixFirstSecond(int [,] array1, int [,] array2)
{
    int[,] matrix = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array2.GetLength(1); i++)
    {
        for (int j = 0; j < array1.GetLength(0); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                matrix[i, j] = matrix[i, j] + array1[i, k] * array2[k, j];
            }
        }
    }
    return matrix;
}







