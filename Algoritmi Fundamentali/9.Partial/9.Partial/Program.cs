namespace _9.Partial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector([1, 2, 3, 4, 5, 5, 5, 3], -10, 10);
            Vector v2 = new Vector([1, 1, 2, 2, 3, 3], -10, 10);
            Console.WriteLine(v1.PowerOfArray());
            Console.WriteLine(v2.PowerOfArray());
            Console.WriteLine(v1 > v2 ? "v1 > v2" : "v1 <= v2");
        }
    }
}
