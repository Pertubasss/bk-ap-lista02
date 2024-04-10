using ExibirMatriz;

namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie uma matriz 4x4 de números inteiros aleatórios e encontre o maior valor presente nela.

            Console.WriteLine(">>> Crie uma matriz 4x4 e exiba o maior valor dela <<<\n");

            int[,] matriz = new int[4, 4];

            var random = new Random();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz[i, j] = random.Next(0, 100);
                }
            }

            Console.WriteLine("A matriz criada aleátoriamente é: ");

            MatrizHelper.ExibirMatriz(matriz, 4);

            int maiorValor = matriz.Cast<int>().Max();

            Console.WriteLine($"\nE seu maior valor da matriz é: {maiorValor}");
        }
    }
}
