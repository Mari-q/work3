
void Zadacha25()
{
    Console.WriteLine("введите число A");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите число B");
    int B = Convert.ToInt32(Console.ReadLine());
    int st = A;

    for (int i = 1; i < B; i++)
    {
    st = st * A;
    }
    Console.WriteLine("A в степени B =: " + st);
}
void Zadacha26()
{
        Console.WriteLine("введите число");
    int i = Convert.ToInt32(Console.ReadLine());
    int sum = 0;

    while (i > 0)
    {
    int num = i % 10;
    i = i / 10;
    sum = sum + num;
    }
    Console.WriteLine("сумма всех цифр в числе = " + sum);
}
void Zadacha27
{
    // Не очень понял, что значит "Вывод отдельным методом" ну ыот, что получилось)

    int[] numbers = new int[8];
    Console.Write("[");

    for (int i = 0; i < numbers.Length; i++)
    {
        numbers [i] = new Random().Next(0, 11);
        Console.Write(" " + Method (i) + " ");
    }
    Console.Write("]");

    int Method (int a)
    {
        return numbers[a];
    }
}
//Zadacha25();
//Zadacha26();
Zadacha27();