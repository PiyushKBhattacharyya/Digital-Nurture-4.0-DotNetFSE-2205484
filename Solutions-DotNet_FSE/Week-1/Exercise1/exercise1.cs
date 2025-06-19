class Singleton
{
    // Static instance
    public static Singleton instance = new Singleton();

    // Private constructor
    private Singleton()
    {
        Console.WriteLine("Singleton Created.");
    }

    public void HelloWorld()
    {
        Console.WriteLine("Hello World!");
    }
}

class exercise1
{
    static void Main(string[] args)
    {
        Singleton.instance.HelloWorld();
    }
}