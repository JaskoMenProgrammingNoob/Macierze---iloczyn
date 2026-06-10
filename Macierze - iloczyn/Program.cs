class Program
{
    static void Main(string[] args)
    {
        int n = 10;
        int[,] macierz = new int[n, n];
        int[,] macierza = new int[n, n];
        int[,] macierziloczyn = new int[n, n];
        Console.WriteLine("     Macierz A: ");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                macierz[i, j] = 1;
            }
        }
        for (int i = 0; i < n; ++i)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{macierz[i, j],2}");
            }
            Console.WriteLine();
        }


        Console.WriteLine("     Macierz B: ");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                macierza[i, j] = 2;
            }
        }
        for (int i = 0; i < n; ++i)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{macierza[i, j],2}");
            }
            Console.WriteLine();
        }
        Console.WriteLine("   Iloczyn macierzy A i B:  ");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                
                for (int k = 0; k < n; k++)
                {
                    macierziloczyn[i, j] += macierza[i, k] * macierz[k, j];
                }

            }

        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{macierziloczyn[i, j], 3}");
            }
            Console.WriteLine();
        }
    }
}