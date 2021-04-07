using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula36
{
    class Program
    {
        static void Main(string[] args)
        {
            //Treinamento - Aula36, inserir dados de entrada, tipo string , int, double
            //Jonas Valereo - Técnico em Informática

            //Declarando as variaveis tipo, string, int, double

            string nome;
            string sobrenome;
            int idade;
            double peso;

            //Declarando  entrada de dado no console, método ReadLine

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu sobrenome: ");
            sobrenome = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu peso: ");
            peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            //imprimir saida de dados no console, e método WhriteLine, concatenação

            Console.WriteLine("O Resultado é !!!");
            Console.WriteLine("Meu nome: " + nome);
            Console.WriteLine("Meu sobrenome: " + sobrenome);
            Console.WriteLine("Minha idade: " + idade + " " + "anos");
            Console.WriteLine("Meu peso: " + peso.ToString("F2", CultureInfo.InvariantCulture) + " Kg ");

            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do progama




        }
    }
}
