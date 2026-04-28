namespace _9.Partial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector ex1 = new Vector([1, 2, 3, 4, 5, 5, 5, 3], -10, 10);
            Vector putere = ex1.PowerOfArray();
            Console.WriteLine(putere);
        }
    }
}
