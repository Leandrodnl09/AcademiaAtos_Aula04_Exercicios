namespace AcademiaAtos_Exercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 18 - Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.

            // Solicita que o usuário digite o primeiro valor
            Console.Write("Digite o primeiro valor: ");

            // Lê o valor digitado pelo usuário e armazena na variável valor1
            int valor1 = int.Parse(Console.ReadLine());

            // Solicita que o usuário digite o segundo valor
            Console.Write("Digite o segundo valor: ");

            // Lê o valor digitado pelo usuário e armazena na variável valor2
            int valor2 = int.Parse(Console.ReadLine());

            // Solicita que o usuário digite o terceiro valor
            Console.Write("Digite o terceiro valor: ");

            // Lê o valor digitado pelo usuário e armazena na variável valor3
            int valor3 = int.Parse(Console.ReadLine());

            // Inicializa a variável maior com o valor de valor1
            int maior = valor1;

            // Compara o valor de valor2 com o valor de maior e atualiza a variável maior caso valor2 seja maior
            if (valor2 > maior)
            {
                maior = valor2;
            }

            // Compara o valor de valor3 com o valor de maior e atualiza a variável maior caso valor3 seja maior
            if (valor3 > maior)
            {
                maior = valor3;
            }

            // Exibe a mensagem informando qual o maior valor encontrado
            Console.WriteLine("O maior valor é: " + maior);
        }
    }
}