namespace ExibirMatriz
{
    public class MatrizHelper
    {
        static void Main()
        {
        }

        public static void ExibirMatriz(int[,] matriz, int tamanho)
        {
            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine();

                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
