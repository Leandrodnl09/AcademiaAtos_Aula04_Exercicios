namespace AcademiaAtos_Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 12 - Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e 
            // número de horas trabalhadas de um operário.Na sequência, calcule o salário sabendo - se que ele ganha
            // R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de pagamento
            // armazenando - o na variável "extra", caso contrário zerar tal variável.A hora excedente de trabalho vale R$ 20,00.
            // No final do processamento, exibir o salário total e o salário excedente do operário.

            int codigo, numeroHoras, horasExtras;
            double salario, salarioExtra = 0;

            Console.Write("Digite o código do operário: ");
            codigo = int.Parse(Console.ReadLine()); // leitura do código do operário

            Console.Write("Digite o número de horas trabalhadas: ");
            numeroHoras = int.Parse(Console.ReadLine()); // leitura do número de horas trabalhadas

            if (numeroHoras <= 50) // verifica se as horas trabalhadas estão dentro da jornada regular
            {
                salario = numeroHoras * 10.0; // cálculo do salário sem horas extras
                horasExtras = 0; // zera as horas extras, já que não há excesso de jornada
            }
            else // caso contrário, há horas extras a serem computadas
            {
                salario = 50 * 10.0; // cálculo do salário sem as horas extras
                horasExtras = numeroHoras - 50; // cálculo das horas extras
                salarioExtra = horasExtras * 20.0; // cálculo do salário referente às horas extras
            }

            Console.WriteLine($"Salário total: R$ {salario + salarioExtra:F2}"); // exibe o salário total
            Console.WriteLine($"Salário referente às horas extras: R$ {salarioExtra:F2}"); // exibe o salário referente às horas extras
        }
    }
}