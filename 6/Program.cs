void Zadacha41()
{
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Какое колличество чисел будет в массиве:");
int M = Convert.ToInt32(Console.ReadLine());
int[] number = new int[M];
int count = 0;
FillArray(number);
PrintArray(number);
{
    for (int i = 0; i < M; i++)
    {
        if (number[i] > 0 ) count += 1;
            Console.Write(number[i] + " ");
            
    
    }
    
}    

 Console.WriteLine();


                    void PrintArray(int[] number)
                    {
                        for (int i = 0; i<M; i++)
                        {
                            Console.Write(number[i] + "  ");
                        }   
                        Console.WriteLine(); 
                    }
                    void FillArray(int[] number)
                    {
                        

                        for (int i = 0; i<M; i++)
                        {
                        Console.Write($" число {i+1}:" );
                        number[i] = Convert.ToInt32(Console.ReadLine());
                        }
                    }


Console.WriteLine($"Чисел больше 0 ввёл пользователь {count}"); 
}
void Zadacha43()
{
    // Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
    Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"точки пересечения двух прямых: {x}, {y}");
}                  
//Zadacha41();
Zadacha43();