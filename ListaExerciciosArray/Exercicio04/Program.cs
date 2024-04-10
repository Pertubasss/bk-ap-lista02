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

            int[] firstVector = new int[3];
            int[] secondVector = new int[3];
            int[] somaVectors = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Digite um valor para a posição {i} do primeiro vetor: ");
                firstVector[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Digite um valor para a posição {i} do segundo vetor: ");
                secondVector[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nO novo vetor com a soma dos anteriores é: \n");

            for (int i = 0; i < 3; i++)
            {
                somaVectors[i] = firstVector[i] + secondVector[i];

                Console.Write($"{somaVectors[i]}"+ "\t");
            }

            Console.WriteLine();
        }
    }
}

