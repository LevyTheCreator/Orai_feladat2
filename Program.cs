// 1.

int abs_max(int n1, int n2)
{
    return (Math.Max(Math.Abs(n1), Math.Abs(n2)));
}

Console.Write("Szam 1: ");
int n1 = int.Parse(Console.ReadLine());

Console.Write("Szam 2: ");
int n2 = int.Parse(Console.ReadLine());

Console.WriteLine(abs_max(n1, n2));

// 2.

int fibo(int n)
{
    int a = 0;
    int b = 1;
    int next = 0;

    for (int i = 0; i < n-1; i++)
    {
        next = a + b;
        a = b;
        b = next;
    }

    return next;
}

Console.Write("Szam: ");
int n3 = int.Parse(Console.ReadLine());

Console.WriteLine(fibo(n3));