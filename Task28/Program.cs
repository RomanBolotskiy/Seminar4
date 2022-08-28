Console.WriteLine("Введите число: ");

int num = int.Parse(Console.ReadLine());

int MultiDigital(int N)
{
    int a = 1;

    for (int i = 2; i <= N; i++)
{
    a = a*i;
}

    return a;
}

Console.Write (MultiDigital(num));
