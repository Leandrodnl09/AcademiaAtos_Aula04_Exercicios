namespace AcademiaAtos_Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 11 - Faça um programa no VS que receba uma hora, dividida em 2 variáveis (uma para hora e outra para minutos).
            // O programa deve exibir se a hora digitada está ou não válida. 
            // Lembre que usaremos o padrão de hora com 24h, de 0 a 23.

            // Solicita ao usuário que informe a hora e os minutos separados por um espaço em branco
            Console.Write("Informe a hora e os minutos (formato: hh mm): ");
            string[] horaMinutos = Console.ReadLine().Split(' ');

            // Verifica se o usuário digitou a hora e os minutos corretamente
            if (horaMinutos.Length != 2)
            {
                Console.WriteLine("Formato de hora inválido!");
            }
            else
            {
                // Converte os valores de hora e minutos para inteiros
                int hora = int.Parse(horaMinutos[0]);
                int minutos = int.Parse(horaMinutos[1]);

                // Verifica se a hora e os minutos informados estão dentro dos limites válidos
                if (hora >= 0 && hora <= 23 && minutos >= 0 && minutos <= 59)
                {
                    Console.WriteLine("Hora válida!");
                }
                else
                {
                    Console.WriteLine("Hora inválida!");
                }
            }
        }
    }
}