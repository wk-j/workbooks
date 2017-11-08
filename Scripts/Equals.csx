byte a = 100;
int b = 100;

Console.WriteLine(a == b);
Console.WriteLine(a.Equals(b));
Console.WriteLine(b.Equals(a));

bool Equals(int a, Object obj)
{
    if (!(obj is Int32)) return false;
    return a == (int)obj;
}

bool Equals(int a, int b)
{
    Console.WriteLine("--");
    return a == b;
}

void E(byte a)
{
    Console.WriteLine("byte");
}

void E(Object a)
{
    Console.WriteLine("object");
}

E(a);
E(b);