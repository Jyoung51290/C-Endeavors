namespace WithTopLevel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            SomeFunction();
        }

        static void SomeFunction()
        {
            Console.WriteLine("SomeFunction");
        }
    }
}

