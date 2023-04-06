namespace AcademiaAtos_Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 14 - Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade de um 
            // link de Internet(em Mbps).Em seguida, calcule e informe o tempo aproximado de download
            // do arquivo usando este link(em minutos).

            // Solicita ao usuário o tamanho do arquivo a ser baixado (em MB)
            Console.Write("Digite o tamanho do arquivo para download (em MB): ");
            double tamanhoArquivo = double.Parse(Console.ReadLine());

            // Solicita ao usuário a velocidade da conexão (em Mbps)
            Console.Write("Digite a velocidade da conexão com a Internet (em Mbps): ");
            double velocidadeInternet = double.Parse(Console.ReadLine());

            // Calcula o tempo aproximado de download (em minutos)
            double tempoDownload = (tamanhoArquivo * 8) / (velocidadeInternet * 60);

            // Exibe o resultado ao usuário
            Console.WriteLine("O tempo aproximado de download é de " + Math.Round(tempoDownload, 2) + " minutos.");
        }
    }
}