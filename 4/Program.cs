
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
void Zadacha27()
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
void Zadacha29()
{
    Random rand = new Random();
    int[] array = new int[8];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0, 8);
    }

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

    Console.WriteLine();
}
//Zadacha25();
//Zadacha27();
Zadacha29();