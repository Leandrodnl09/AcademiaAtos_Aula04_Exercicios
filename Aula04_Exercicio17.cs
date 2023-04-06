using System.Net;
using System.Runtime.ConstrainedExecution;

namespace AcademiaAtos_Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 17 - Faça um algoritmo em C# que leia o tamanho dos lados de um triangulo (lado a, b e c),
            // e então diga se esses lados podem ou não formar um triangulo. Para que os lados
            // formem um triângulo, todos os lados devem ser menores ou iguais a soma dos outros dois lados. 
            // Caso os lados formem um triangulo, diga se o mesmo é equilátero(todos
            // os lados iguais), isoceles(somente 2 lados são iguais) ou escaleno(os 3 lados são diferentes). 


            // lê o tamanho dos lados do triângulo
            Console.WriteLine("Digite o tamanho dos lados do triângulo:");
            Console.Write("Lado a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Lado b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Lado c: ");
            int c = int.Parse(Console.ReadLine());

            // verifica se é possível formar um triângulo
            if (a < b + c && b < a + c && c < a + b)
            {
                // se é possível, verifica o tipo de triângulo formado
                if (a == b && b == c)
                {
                    Console.WriteLine("Triângulo equilátero.");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("Triângulo isósceles.");
                }
                else
                {
                    Console.WriteLine("Triângulo escaleno.");
                }
            }
            else
            {
                Console.WriteLine("Não é possível formar um triângulo.");
            }
        }
    }
}