/*Задача 50. Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание,
что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет/*/


Console.Write("Введите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца: ");
int column = Convert.ToInt32(Console.ReadLine());

int kolvoStrok = new Random().Next(5, 11);
int kolvoStolbcov = new Random().Next(5, 11);


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


int[,] resultMatrix = GetMatrix(kolvoStrok, kolvoStolbcov);

if (row < kolvoStrok & column < kolvoStolbcov)
    {
    Console.WriteLine($"Элемент на позиции строка {row}, столбец {column} равен: {resultMatrix[row, column]}");

    }
else 
{
    Console.WriteLine("Элемента на такой позиции в массиве нет");
}

PrintMatrix(resultMatrix);
