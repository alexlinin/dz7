/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/


Console.Write("Введите количество строк в массиве: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++) 
    {
        
        for (int j = 0; j < n; j++) 
        {
            
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t"); 
        }
        Console.WriteLine();
    }
}


int[,] resultMatrix = GetMatrix(row, column);

double sum = 0;
for (int j = 0; j < column; j++) 
    {
        
        for (int i = 0; i < row; i++) 
        {
            sum += resultMatrix[i, j];
        }
        Console.WriteLine($"Среднее арифметическое в столбце {j} равно: {Math.Round(sum/row, 1)}");
        sum = 0;
    }

PrintMatrix(resultMatrix);
