void Zadacha64()
{
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
int n = InputNumbers("Введите n: ");
int count = 2;
PrintNumber(n, count);
Console.Write(1);

void PrintNumber(int n, int count)
{
  if (count > n) return;
  PrintNumber(n, count + 1);
  Console.Write(count + ", ");
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
}
void  Zadacha66()
{
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

SumFromMToN(m, n);
void SumFromMToN(int m, int n)
{
    Console.Write(SumMN(m - 1, n));
}
int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}
}
void Zadacha68()
{
    Console.WriteLine("Введите два положительных числа: M и N.");
    int m = InputInt("Введите M: ");
    int n = InputInt("Введите N: ");
    Console.WriteLine($"A({m}, {n}) = {Ackerman(m, n)}");

    int InputInt(string output)
    {
        Console.Write(output);
        return int.Parse(Console.ReadLine());
    }

    int Ackerman(int m, int n)
    {
        if (m == 0)
            return n + 1;
        if (m > 0 && n == 0)
            return Ackerman(m - 1, 1);
        else
            return Ackerman(m - 1, Ackerman(m, n - 1));
    }
}
//Zadacha64();
//Zadacha66();
Zadacha68();