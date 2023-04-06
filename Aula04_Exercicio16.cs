using System.Runtime.Intrinsics.X86;

namespace AcademiaAtos_Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 16 - Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil. Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre
            // na tela uma mensagem indicando que o time de fora já se classificou para a próxima fase.Caso contrário, mostre uma mensagem indicando que os dois times irão se
            // enfrentar novamente em um novo jogo.
            // ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"
            // ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
            // plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase.


            // Solicita que o usuário digite os times que se enfrentaram
            Console.WriteLine("Digite o nome dos times que vão se enfrentar (xxxx X yyyyy):");
            // Lê a string digitada pelo usuário e divide em duas partes
            string[] times = Console.ReadLine().Split(' ');

            // Extrai os valores do placar em duas variáveis
            string time1 = times[0];
            string time2 = times[2];

            // Solicita que o usuário digite o placar do primeiro jogo
            Console.Write($"Digite o placar do jogo no formato ({time1} X {time2}): ");
            // Lê a string digitada pelo usuário e divide em duas partes
            string[] placar = Console.ReadLine().Split(' ');

            // Extrai os valores do placar em duas variáveis
            int placarCasa = int.Parse(placar[0]); // Palmeiras
            int placarFora = int.Parse(placar[2]); // Vasco

            // Verifica se o time de fora ganhou por mais de 2 gols de diferença
            if (placarFora - placarCasa > 2)
            {
                // Exibe a mensagem indicando que o time de fora se classificou
                Console.WriteLine($"O {time2} se classificou.");
            }
            else
            {
                // Exibe a mensagem indicando que haverá um segundo jogo
                Console.WriteLine($"O {time1} e {time2} se enfrentarão em um novo jogo.");

                // Solicita que o usuário digite o placar do segundo jogo
                Console.Write($"Digite o placar do segundo jogo no formato ({time2} x {time1}): ");
                // Lê a string digitada pelo usuário e divide em duas partes
                string[] placar2 = Console.ReadLine().Split(' ');

                // Extrai os valores do placar em duas variáveis
                int placarCasa2 = int.Parse(placar2[0]); // Vasco
                int placarFora2 = int.Parse(placar2[2]); // Palmeiras

                // Verifica quem passou de fase
                if (placarFora2 - placarCasa2 > placarFora - placarCasa)
                {
                    // Exibe a mensagem indicando que o time de casa se classificou
                    Console.WriteLine($"O {time1} se classificou.");
                }
                else if  (placarFora2 - placarCasa2 < placarFora - placarCasa)
                {
                    // Exibe a mensagem indicando que o time de fora se classificou
                    Console.WriteLine($"O {time2} se classificou.");
                }
                else if ((placarFora2 - placarCasa2) == (placarFora - placarCasa))
                {
                    // Exibe a mensagem indicando que os times empataram no placar agregado
                    Console.WriteLine("Os dois times empataram no placar agregado.");
                }
            }

        }
    }
}