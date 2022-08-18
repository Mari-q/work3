void Zadacha47()
{
    // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
    Console.WriteLine("количество m строк?");
    int lines = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("количество n столбцов?");
    int columns = Convert.ToInt32(Console.ReadLine());
    double[,] number = new double[lines, columns];
    FillArrayNumbers(number);
    PrintArray(number);

        void FillArrayNumbers(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
                }
            }
        }
        void PrintArray(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
}
void Zadacha50()
{
    //Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
    Console.WriteLine("количество m строк?");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("количество n столбцов?");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] number = new int [m, n];
    Console.WriteLine($"позиция строки m");
    int m1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"позиция строки n");
    int n1 = Convert.ToInt32(Console.ReadLine());
    FillArrayNumber(number);
    PrintArray(number);

        void FillArrayNumber(int[,] number)
        {
            for (int i = 0; i < number.GetLength(0); i++)
            {
                for (int j = 0; j < number.GetLength(1); j++)
                {
                    number[i, j] = new Random().Next(0, 10);
                }
            }
        }
        void PrintArray(int [,] numder)
        {
            for (int i = 0; i < numder.GetLength(0); i++)
            {
                for (int j = 0; j < numder.GetLength(1); j++)
                {
                    Console.Write(numder[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
     if (m1 > number.GetLength(0) || n1 > number.GetLength(1))
{
    Console.WriteLine("такого числа в массиве нет");
}
else
{
    Console.WriteLine($"число строки {m1}  и столбеца {n1} равно {number[m1-1,n1-1]}");
}
   

}
void Zadacha52()
{
    //Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("количество m строк?");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("количество n столбцов?");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] number = new int[m, n];
    
    FillArrayNumber(number);
    PrintArray(number);

        void FillArrayNumber(int[,] number)
        {
            for (int i = 0; i < number.GetLength(0); i++)
            {
                for (int j = 0; j < number.GetLength(1); j++)
                {
                    number[i, j] = new Random().Next(0, 10);
                }
            }
        }
        void PrintArray(int [,] numder)
        {
            for (int i = 0; i < numder.GetLength(0); i++)
            {
                for (int j = 0; j < numder.GetLength(1); j++)
                {
                    Console.Write(numder[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
   for (int j = 0; j < number.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < number.GetLength(0); i++)
    {
        avarage = (avarage + number[i, j]);
    }
    avarage = avarage / m;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
}
Zadacha52();
//Zadacha50();
//Zadacha47();