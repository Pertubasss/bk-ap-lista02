using ExibirMatriz;

namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa que declare dois vetores de mesmo tamanho e calcule a soma dos elementos correspondentes de ambos os vetores,
            //armazenando o resultado em um terceiro vetor. Em seguida, exiba o vetor resultante.

            Console.WriteLine(">>> Criação de dois vetores somando ambos e salvando em um terceiro <<<\n");

            //int[] firstVector = { 40, 10, 25, 4, 5 };
            //int[] secondVector = { 40, 10, 25, 4, 5 };

            Console.Write("Digite o valor do vetor: ");
            if (int.TryParse(Console.ReadLine(), out int valorVetor))
            {
                int[] firstVector = new int[valorVetor];
                int[] secondVector = new int[valorVetor];
                int[] somaVectors = new int[valorVetor];

                Console.WriteLine("\nVector [1]");

                ExHelper.PreencherVetor(firstVector);

                Console.WriteLine("\nVector [2]");

                ExHelper.PreencherVetor(secondVector);

                for (int i = 0; i < somaVectors.Length; i++)
                {
                    somaVectors[i] = firstVector[i] + secondVector[i];

                    Console.Write($"\n{somaVectors[i]}" + "\t");
                }

            }
        }
    }
}

