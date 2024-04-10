namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //01 - Escreva um programa que declare e inicialize um vetor com 5 elementos inteiros e, em seguida, exiba esses elementos na tela.

            Console.WriteLine(">>> Exibir array com 5 elementos inteiros <<<\n");

            int[] ints = new int[5] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Os elementos informados são: \n");

            foreach (int element in ints)
            {
                Console.Write(element + "\t");
            }
        }
    }
}
