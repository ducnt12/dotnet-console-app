static class Utilities
{
    public static void SayHello()
    {
        System.Console.WriteLine("Hello world!");
    }

    public static void SayWaiting()
    {
        System.Console.WriteLine("Please be patient");
    }


    //static Method overloading
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static void Add(int a, int b, int c)
    {
        System.Console.WriteLine(a + b + c);
    }
}