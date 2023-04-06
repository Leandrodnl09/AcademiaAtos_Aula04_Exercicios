using System.Runtime.Intrinsics.X86;

namespace AcademiaAtos_Exercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 20 - Escreva um algoritmo para o jogo de adivinhação do número secreto. O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. 
            // plus: você pode gerar o número de forma randomica(função random c#).

            // gerando um número aleatório entre 1 e 100
            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);

            int tentativasRestantes = 3;
            int palpite = 0;

            Console.WriteLine("Bem-vindo ao jogo de adivinhação do número secreto!");
            Console.WriteLine("Você tem 3 chances para adivinhar o número secreto entre 1 e 100.");

            // loop de jogo principal
            while (tentativasRestantes > 0)
            {
                Console.WriteLine($"Tentativas restantes: {tentativasRestantes}");
                // Palpite que o usuario irá digitar
                Console.Write("Digite o seu palpite: ");
                palpite = int.Parse(Console.ReadLine());

                if (palpite == numeroSecreto) 
                {
                    Console.WriteLine("Parabéns! Você acertou o número secreto!");
                }
                else if (palpite < numeroSecreto)
                {
                    Console.WriteLine("O número secreto é maior do que o seu palpite.");
                }
                else
                {
                    Console.WriteLine("O número secreto é menor do que o seu palpite.");
                }

                tentativasRestantes--; // Diminui o numero de tentativas
            }

            Console.WriteLine("Você perdeu! O número secreto era: " + numeroSecreto);
        }
    }
}