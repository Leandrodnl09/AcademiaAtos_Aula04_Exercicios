namespace AcademiaAtos_Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 13 - Tendo como dado de entrada a altura (h) de uma pessoa, construa um programa no VS que calcule 
            // seu peso ideal, utilizando as seguintes fórmulas:
            // Para homens: (72.7 * h) - 58
            // Para mulheres: (62.1 * h) - 44.7

            // Pedimos ao usuário que informe sua altura em metros
            Console.WriteLine("Informe sua altura em metros: ");
            double altura = double.Parse(Console.ReadLine());

            // Pedimos ao usuário que informe seu sexo
            Console.WriteLine("Informe seu sexo (M para masculino ou F para feminino): ");
            string sexo = Console.ReadLine();

            // Verificamos o sexo informado pelo usuário e calculamos o peso ideal com a fórmula correspondente
            double pesoIdeal;
            if (sexo == "M")
            {
                pesoIdeal = (72.7 * altura) - 58;
                Console.WriteLine($"Seu peso ideal é {pesoIdeal:N2} kg.");
            }
            else if (sexo == "F")
            {
                pesoIdeal = (62.1 * altura) - 44.7;
                Console.WriteLine($"Seu peso ideal é {pesoIdeal:N2} kg.");
            }
            else
            {
                Console.WriteLine("Sexo inválido!");
            }
        }
    }
}