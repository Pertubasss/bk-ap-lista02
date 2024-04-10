﻿using ExibirMatriz;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa que preencha uma matriz 3x3 com valores inteiros informados pelo usuário e depois exiba essa matriz na tela.

            Console.WriteLine(">>> Preenche uma matriz 3x3 <<<\n");

            int[,] matriz = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Digite um valor para a posição {i}x{j}: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Clear();

            Console.WriteLine("Valores digitados na matriz:");

            MatrizHelper.ExibirMatriz(matriz, 3);
        }
    }
}
