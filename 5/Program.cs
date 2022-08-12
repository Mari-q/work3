void Zadacha34()
{
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Сколько чисел в массиве:");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int count = 0;
Random random = new Random();
FillRandArray(array, 100, 999);
 PrintArray(array);
for (int i = 0; i<size; i++)
{
    if (array[i] % 2 == 0)
    {
        Console.Write(array[i] + " ");
        count++;
       
    }    
}
Console.WriteLine();

Console.WriteLine("Количество четных чисел в массиве:"+ count );
}   


void PrintArray(int[] array)
{
    int size = array.Length;
   for (int i = 0; i<size; i++)
    {
        Console.Write(array[i] + "  ");
    }   
    Console.WriteLine(); 
}
void FillRandArray(int[] array, int startNumber, int finishNumber)
{
    
    int size = array.Length;
    Random random = new Random();
    for (int i = 0; i<size; i++)
    {
    array[i] = random.Next(startNumber, finishNumber);
    }
}


void Zadacha36()
{
    //Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящихна нечётных позициях.

Console.WriteLine("Сколько чисел в массиве:");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int count = 0;
int sum = 0;
FillRandArray(array, 0,100);
PrintArray(array);
for (int i = 0; i<array.Length; i+=2)
{
    Console.Write(i+1);     
    Console.Write("  ");
    sum = sum + array[i];
}
Console.WriteLine("сумма не четных чисел в массиве:"+ sum );
}
void FillArrayDoublNumb(double[] namb, int startNumber, int finishNumber)
{
    int size = namb.Length;
    Random random = new Random();
    for(int i = 0; i < size; i++)
        {
            namb[i] = Convert.ToDouble(new Random().Next(startNumber, finishNumber)) / 100;
        }
}


void PrintNumb(double[] numb)
{
    Console.Write("[ ");
    for(int i = 0; i < numb.Length; i++)
        {
            Console.Write(numb[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}



void Zadacha38()
{
    //Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Сколько чисел в массиве:");
int size = Convert.ToInt32(Console.ReadLine());
double[] numb = new double[size];
FillArrayDoublNumb(numb, 1, 1000);
PrintNumb(numb);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < size; i++)
{
    if (numb[i] > max)
        {
            max = numb[i];
        }
    if (numb[i] < min)
        {
            min = numb[i];
        }
}
Console.WriteLine($" max = {max}, min= {min}");
Console.WriteLine($"Разница max & min = {max - min}");

}
//Zadacha34();
//Zadacha36();
Zadacha38();