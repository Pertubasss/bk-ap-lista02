namespace ExibirMatriz
{
    public class ExHelper
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

        public static void PreencherVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("Digite um número inteiro: ");
                if (int.TryParse(Console.ReadLine(), out int numDigitado))
                {
                    vetor[i] = numDigitado;
                }
                else
                {
                    Console.WriteLine("O valor digítado não é um numero inteiro, tente novamente...");
                    i--;
                }
            }
        }
    }
}
