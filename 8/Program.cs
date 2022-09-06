void Zadacha54()
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
{
Console.WriteLine("количество строк?");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("количество столбцов?");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[rows, column];
FillArrayMatrix(matrix);
PrintArray(matrix);
Console.WriteLine("");

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
    for (int y = 0; y < matrix.GetLength(1) - 1; y++)
        {
            if (matrix[i, y] < matrix[i, y + 1]) 
                {
                    int temp = 0;
                    temp = matrix[i, y];
                    matrix[i, y] = matrix[i, y + 1];
                    matrix[i, y + 1] = temp;
                }
        }
    }
}
Console.WriteLine("упорядоченный массив");
PrintArray(matrix);
Console.WriteLine();
}
void Zadacha56()
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

{
    Console.WriteLine("количество строк?");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("количество столбцов?");
    int column = Convert.ToInt32(Console.ReadLine());
    int[,] matrix = new int[rows, column];
    FillArrayMatrix(matrix);
    PrintArray(matrix); 
    int minSumLine = 0;
    int sumLine = SumLineElements(matrix, 0);
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
    int tempSumLine = SumLineElements(matrix, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
    }
    Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");
    int SumLineElements(int[,] matrix, int i)
    {
    int sumLine = matrix[i,0];
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        sumLine += matrix[i,j];
    }
    return sumLine;
    }

    int InputNumbers(string input)
    {
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
    }

}


        void FillArrayMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = new Random().Next(-10, 10);
                }
            }
        }
        void PrintArray(int [,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }

//Zadacha54();
Zadacha56();