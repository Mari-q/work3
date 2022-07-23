void Zadacha19()
{
    Console.WriteLine("Введите число: ");
    int numb = Convert.ToInt32(Console.ReadLine());
    if (numb < 10000 || numb > 99999)
    {
        Console.WriteLine("число не пятизначное");
    }

    else 
    {
        int digital1 = numb / 10000 % 10;
        int digital2 = numb / 1000 % 10;
        int digital4 = numb / 10 % 10;
        int digital5 = numb % 10;

        if (digital1 == digital5 && digital2 == digital4)
        {
            Console.WriteLine("палиндромом");
        }

        else
        {
            Console.WriteLine(" не палиндромом");
        }
    }
}
void Zadacha21()
{
    Console.WriteLine("кордината A x1=");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("кордината A y1=");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("кордината A z1=");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("кордината B x2=");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("кордината B y2=");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("кордината B z2=");
int z2 = Convert.ToInt32(Console.ReadLine());
double S = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
    Console.WriteLine(S);
}


void Zadacha23()
{
    Console.WriteLine("Введите число:");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number >= 1)
    {
       int startnumber = 1;
        while (startnumber <= number)
        {
            Console.WriteLine($"куб {Math.Pow(startnumber, 3)}");
            startnumber++;
        }
    }
    else
    {
        Console.WriteLine("не соответствует");
    }
}
//Zadacha19();
Zadacha21();
//Zadacha23();