Console.WriteLine("Hello, to Fibonnaci Love!");
System.Console.WriteLine("How many Fibonnaci Iterations do you want?");
int o = int.Parse(Console.ReadLine());



ulong x = 0;
ulong y = 1;
ulong z;

System.Console.WriteLine(x);
System.Console.WriteLine(y);



for (int i = 2; i < o; i++)
{
    z = x + y;
    System.Console.WriteLine(z);
    x = y;
    y = z;
}

