namespace AcademiaAtos_Exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 19 - Ajuste o exercício 18 de maneira que mostre os valores informados em ordem crescente.

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

            // Inicializa as variáveis menor, meio e maior
            int menor, meio, maior;

            // Compara os valores e atribui os valores corretos às variáveis menor, meio e maior
            if (valor1 <= valor2 && valor1 <= valor3)
            {
                menor = valor1;
                if (valor2 <= valor3)
                {
                    meio = valor2;
                    maior = valor3;
                }
                else
                {
                    meio = valor3;
                    maior = valor2;
                }
            }
            else if (valor2 <= valor1 && valor2 <= valor3)
            {
                menor = valor2;
                if (valor1 <= valor3)
                {
                    meio = valor1;
                    maior = valor3;
                }
                else
                {
                    meio = valor3;
                    maior = valor1;
                }
            }
            else
            {
                menor = valor3;
                if (valor1 <= valor2)
                {
                    meio = valor1;
                    maior = valor2;
                }
                else
                {
                    meio = valor2;
                    maior = valor1;
                }
            }

            // Exibe a mensagem informando os valores em ordem crescente
            Console.WriteLine("Valores em ordem crescente: " + menor + ", " + meio + ", " + maior);

            // Exibe a mensagem informando qual o maior valor encontrado
            Console.WriteLine("O maior valor é: " + maior);
        }
    }
}