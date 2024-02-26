namespace Ejercicio9hoja4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10; // Tamaño de la matriz (10x10)
            int[,] matriz = new int[n, n];

            int i = 1;
            while (i <= n)
            {
                int j = i;
                while (j <= n)
                {
                    matriz[i - 1, j - 1] = matriz[j - 1, i - 1] = i * j;
                    j++;
                }
                i++;
            }

            i = 1;
            while (i <= n)
            {
                int j = 1;
                while (j < i)
                {
                    Console.Write("  "); // Espacios para alinear la matriz
                    j++;
                }
                while (j <= n)
                {
                    Console.Write(matriz[i - 1, j - 1] + " ");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
        }
    }
}
