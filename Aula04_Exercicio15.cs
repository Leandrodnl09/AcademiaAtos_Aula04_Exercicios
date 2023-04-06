using System.IO;

namespace AcademiaAtos_Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 15 - Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados 
            // da área a ser pintada.Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados
            // e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00.
            // Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.

            // Variaveis;
            int tamanho, latas;
            double litros, preco;

            Console.Write("Informe o tamanho em metros quadrados da área a ser pintada: ");
            tamanho = int.Parse(Console.ReadLine());

            // Calcula a quantidade de litros de tinta necessários
            litros = (double)tamanho / 3.0;

            // Calcula a quantidade de latas de tinta necessárias, arredondando para cima
            latas = (int)Math.Ceiling(litros / 18.0);

            // Calcula o preço total das latas de tinta
            preco = latas * 80.0;

            Console.WriteLine("Quantidade de latas de tinta a serem compradas: " + latas);
            Console.WriteLine("Preço total: R$ " + preco.ToString("F2"));
        }
    }
}