namespace UniterOfAdds;

class Program
{
    static void Main(string[] args)
    {
        dynamic a = "5";
        dynamic b = 10;
        Console.WriteLine(Adds.Add(a, b));
    }
}

public static class Adds
{
    public static dynamic Add(dynamic a, dynamic b) => a + b;
    // public static int Add(int a, int b) => a + b;
    // public static double Add(double a, double b) => a + b;
    // public static string Add(string a, string b) => a + b;
    // public static DateTime Add(DateTime a, TimeSpan b) => a + b;
}