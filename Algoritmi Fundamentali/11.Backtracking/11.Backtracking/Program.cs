namespace _11.Backtracking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5, k = 3;
            int[] solution = new int[k];
            bool[] visited = new bool[n];

            ProdusCartezian(solution, k, 0);
            Console.WriteLine();

            solution = new int[n];
            Permutari(solution, visited, n, 0);
            Console.WriteLine();

            solution = new int[k];
            Aranjamente(solution, visited, n, k, 0);
            Console.WriteLine();

            solution = new int[k + 1];
            Combinari(solution, n, k, 1);
        }

        static void ProdusCartezian(int[] solution, int n, int p)
        {
            if (p >= n)
            {
                for (int i = 0; i < n; i++)
                    Console.Write(solution[i] + " ");
                Console.WriteLine();
                return;
            }
            for (int i = 1; i <= n; i++)
            {
                solution[p] = i;
                ProdusCartezian(solution, n, p + 1);
            }
        }

        static void Permutari(int[] solution, bool[] visited, int n, int p)
        {
            if (p >= n)
            {
                for (int i = 0; i < n; i++)
                    Console.Write(solution[i] + " ");
                Console.WriteLine();
                return;
            }
            for (int i = 1; i <= n; i++)
            {
                if (!visited[i - 1])
                {
                    solution[p] = i;
                    visited[i - 1] = true;
                    Permutari(solution, visited, n, p + 1);
                    visited[i - 1] = false;
                }
            }
        }

        static void Aranjamente(int[] solution, bool[] visited, int n, int k, int p)
        {
            if (p >= k)
            {
                for (int i = 0; i < k; i++)
                    Console.Write(solution[i] + " ");
                Console.WriteLine();
                return;
            }
            for (int i = 1; i <= n; i++)
            {
                if (!visited[i - 1])
                {
                    solution[p] = i;
                    visited[i - 1] = true;
                    Aranjamente(solution, visited, n, k, p + 1);
                    visited[i - 1] = false;
                }
            }
        }

        static void Combinari(int[] solution, int n, int k, int p)
        {
            if (p > k)
            {
                for (int i = 1; i <= k; i++)
                    Console.Write(solution[i] + " ");
                Console.WriteLine();
                return;
            }
            for (int i = solution[p - 1] + 1; i <= n; i++)
            {
                solution[p] = i;
                Combinari(solution, n, k, p + 1);
            }
        }
    }
}
