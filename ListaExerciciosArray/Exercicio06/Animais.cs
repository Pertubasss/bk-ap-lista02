using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    class Animais(string nome, string especie, int idade, double peso)
    {
        public string Nome { get; set; } = nome;
        public string Especie { get; set; } = especie;
        public int Idade { get; set; } = idade;
        public double Peso { get; set; } = peso;

        public override string ToString()
        {
            return $"Nome: {Nome}, Espécie: {Especie}, Idade: {Idade}, Peso: {Peso}";
        }
    }
}
