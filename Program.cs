// 1.

//int abs_max(int n1, int n2)
//{
//    return (Math.Max(Math.Abs(n1), Math.Abs(n2)));
//}

//Console.Write("Szam 1: ");
//int n1 = int.Parse(Console.ReadLine());

//Console.Write("Szam 2: ");
//int n2 = int.Parse(Console.ReadLine());

//Console.WriteLine(abs_max(n1, n2));

//// 2.

//int fibo(int n)
//{
//    int a = 0;
//    int b = 1;
//    int next = 0;

//    for (int i = 0; i < n-1; i++)
//    {
//        next = a + b;
//        a = b;
//        b = next;
//    }

//    return next;
//}

//Console.Write("Szam: ");
//int n3 = int.Parse(Console.ReadLine());

//Console.WriteLine(fibo(n3));

// 6.

int jelszo_erosseg(string pw)
{
    int strength = 1;
    int length = pw.Count();

    if (length >= 5)
    {
        strength += 1;
    }

    if (length >= 8)
    {
        strength += 2;
    }

    int amount = 0;
    char[] spec_char = { '-', '_', '.' };
    foreach (char charachter in pw)
    {
        if (spec_char.Contains(charachter))
        {
            amount += 1;
        }
    }

    if (amount > 0)
    {
        strength += amount * 2;
    }

    if (pw.Contains("123") || pw.Contains("jelszo"))
    {
        strength = 0;
    }

    if (length == 0)
    {
        strength = 0;
    }

    return strength;
}

Console.WriteLine(jelszo_erosseg("hazi_macska_4_life"));

// 7.

Console.Write("Mondat: ");
string sent = Console.ReadLine();


string maganhabgzo_torol(string sent)
{
    char[] hun_char = { 'a', 'e', 'i', 'o', 'u' };

    string new_sent = "";

    foreach (char c in sent)
    {
        if (hun_char.Contains(c))
        {
            continue;
        }
        else
        {
            new_sent += c;
        }
    }

    return new_sent;
}

Console.WriteLine(maganhabgzo_torol(sent));