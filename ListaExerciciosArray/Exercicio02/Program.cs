namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa que declare e inicialize um vetor com 5 elementos inteiros e, em seguida, mostre o maior e menor valor.

            Console.WriteLine(">>> Exibir array com 5 elementos inteiros e exibir o maior e menor valor <<<\n");

            //int[] ints = { 40, 10, 25, 4, 5 };

            int[] ints = new int[5];

            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write("Digite um número inteiro: ");
                if (int.TryParse(Console.ReadLine(), out int numDigitado))
                {
                    ints[i] = numDigitado;
                }
                else
                {
                    Console.WriteLine("O valor digítado não é um numero inteiro, tente novamente...");
                    i--;
                }
            }

            Console.WriteLine("\nOs valores do array são: \n");

            foreach (int element in ints)
            {
                Console.Write(element + "\t");
            }

            Console.WriteLine("\n");

            //int menor = ints.Min();
            //int maior = ints.Max();

            int menor = MenorValor(ints);
            int maior = MaiorValor(ints);

            Console.WriteLine($"Menor valor: {menor}");
            Console.WriteLine($"Maior valor: {maior}");
        }

        private static int MenorValor(int[] ints)
        {
            int menor = ints[0];

            foreach (int elemento in ints)
            {
                if (elemento < menor)
                {
                    menor = elemento;
                }
            }

            return menor;
        }

        private static int MaiorValor(int[] ints)
        {
            int menor = ints[0];

            foreach (int elemento in ints)
            {
                if (elemento > menor)
                {
                    menor = elemento;
                }
            }

            return menor;
        }
    }
}
