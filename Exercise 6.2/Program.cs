namespace Exercise_6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string commandLineArgumentString = args[0];
            int commandLineArgumentInt = int.Parse(args[1]);


            Console.WriteLine($"String: {commandLineArgumentString}");
            Console.WriteLine($"Integer: {commandLineArgumentInt}");
        }
    }
}
