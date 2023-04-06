using System.Drawing;
using System;

namespace AcademiaAtos_Exercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 21 - Crie um programa que permita que o usuário selecione uma unidade de medida de entrada (metros, centímetros, polegadas ou pés)
            // e uma unidade de medida de saída usando um menu com o comando switch case.
            // O programa deve, em seguida, pedir ao usuário um valor de entrada e converter esse
            // valor para a unidade de saída selecionada.

            // Exibe o menu de seleção de unidade de medida de entrada
            Console.WriteLine("Selecione a unidade de medida de entrada:");
            Console.WriteLine("1 - metros");
            Console.WriteLine("2 - centímetros");
            Console.WriteLine("3 - polegadas");
            Console.WriteLine("4 - pés");

            // Lê a opção selecionada pelo usuário
            int opcaoEntrada = int.Parse(Console.ReadLine());

            // Exibe o menu de seleção de unidade de medida de saída
            Console.WriteLine("Selecione a unidade de medida de saída:");
            Console.WriteLine("1 - metros");
            Console.WriteLine("2 - centímetros");
            Console.WriteLine("3 - polegadas");
            Console.WriteLine("4 - pés");

            // Lê a opção selecionada pelo usuário
            int opcaoSaida = int.Parse(Console.ReadLine());

            // Lê o valor de entrada fornecido pelo usuário
            Console.WriteLine("Digite o valor de entrada:");
            double valorEntrada = double.Parse(Console.ReadLine());

            // Converte o valor de entrada para metros
            switch (opcaoEntrada)
            {
                case 1: // metros
                    break;
                case 2: // centímetros
                    valorEntrada /= 100.0;
                    break;
                case 3: // polegadas
                    valorEntrada *= 0.0254;
                    break;
                case 4: // pés
                    valorEntrada *= 0.3048;
                    break;
            }

            // Converte o valor de entrada para a unidade de medida de saída selecionada
            double valorSaida = 0.0;
            switch (opcaoSaida)
            {
                case 1: // metros
                    valorSaida = valorEntrada;
                    break;
                case 2: // centímetros
                    valorSaida = valorEntrada * 100.0;
                    break;
                case 3: // polegadas
                    valorSaida = valorEntrada / 0.0254;
                    break;
                case 4: // pés
                    valorSaida = valorEntrada / 0.3048;
                    break;
            }

            // Exibe o valor de saída convertido para a unidade de medida selecionada
            Console.WriteLine("Valor de saída: " + valorSaida.ToString("F5"));
        }
    }
}