namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animais[,] animais = new Animais[,]
            {
                { new Animais("Happy", "Gato", 2, 2)
                , new Animais("Peteleco", "Cachorro", 10, 8)
                , new Animais("Chavo", "Cachorro", 8, 5)
                , new Animais("Amy", "Gato", 5, 3) }
            };

            string busca = Busca();

            if (!busca.Equals("todos"))
            {
                Console.Write($"\nDigite o valor para a propriedade {busca} para que possamos buscar: ");
                string? valorBusca = Console.ReadLine().ToLower();

                BuscarAnimais(animais, busca, valorBusca);

                Console.ReadKey();
            }

            BuscarAnimais(animais, busca);

        }

        static void BuscarAnimais(Animais[,] animais, string propriedade, string busca = "")
        {
            bool encontrouAnimais = false;

            foreach (Animais animal in animais)
            {
                switch (propriedade)
                {
                    case "nome":
                        if (animal.Nome.ToLower() == busca.ToLower())
                        {
                            Console.WriteLine(animal);
                            encontrouAnimais = true;
                        }
                        break;

                    case "espécie":
                        if (animal.Especie.ToLower() == busca.ToLower())
                        {
                            Console.WriteLine(animal);
                            encontrouAnimais = true;
                        }
                        break;

                    case "idade":
                        if (int.TryParse(busca, out int idade) && animal.Idade == idade)
                        {
                            Console.WriteLine(animal);
                            encontrouAnimais = true;
                        }
                        else
                        {
                            throw new ArgumentException("Valor de idade inválido.");
                        }
                        break;

                    case "peso":
                        if (animal.Peso.ToString().ToLower() == busca.ToLower())
                        {
                            Console.WriteLine(animal);
                            encontrouAnimais = true;
                        }
                        break;

                    case "todos":
                        Console.WriteLine(animal);
                        encontrouAnimais = true;
                        break;

                    default:
                        throw new ArgumentException("Propriedade não encontrada...");
                }
            }

            if (!encontrouAnimais)
            {
                Console.WriteLine("Nenhum animal encontrado com as especificações fornecidas...");
            }
        }

        static string Busca()
        {
            Console.Write("1 - Nome;" +
                "\n2 - Especie" +
                "\n3 - Idade" +
                "\n4 - Peso" +
                "\n5 - Exibir todos animais disponiveis" +
                "\n\nEscolha o numero da propriedade que deseja buscar: ");

            if (int.TryParse(Console.ReadLine(), out int opcao))
            {
                switch (opcao)
                {
                    case 1:
                        return "nome";

                    case 2:
                        return "espécie";

                    case 3:
                        return "idade";

                    case 4:
                        return "peso";

                    case 5:
                        return "todos";

                    default:
                        throw new ArgumentException("Opção inválida");
                }
            }
            else
            {
                throw new ArgumentException("Opção inválida");
            }
        }

    }
}
