using System;

namespace Desafio03
{
    public class Program
    {
        public static void Main()
        {
            var horaSaida = ObterHoraSaida();
            var tempoViagem = ObterTempoViagem();
            var fuso = ObterFusoHorario();

            int horaChegada = 0;

            horaChegada = Math.Abs(calcularHora(horaSaida + tempoViagem + fuso));
            Console.WriteLine($"Hora Chegada: {horaChegada}");
        }

        static int calcularHora(int hora)
        {
            if (hora > 24)
            {
                return 24 - hora;
            }
            if (hora < 0)
            {
                return 24 - Math.Abs(hora);
            }
            return hora;
        }
        private static int ObterHoraSaida()
        {
            Console.WriteLine("Digite o Horario de saída");
            int horaSaida = Convert.ToInt32(Console.ReadLine());
            if (horaSaida < 0 && horaSaida > 23)
            {
                throw new Exception("Hora de saída deve ser maior ou igual a 0 e menor ou igual a 23");
            }
            return horaSaida;
        }
        private static int ObterTempoViagem()
        {
            Console.WriteLine("Insira o tempo de viagem");
            int tempoViagem = Convert.ToInt32(Console.ReadLine());
            if (tempoViagem < 1 && tempoViagem > 12)
            {
                throw new Exception("Tempo de Viagem deve ser maior ou igual a 1 e menor ou igual a 12");
            }
            return tempoViagem;
        }
        private static int ObterFusoHorario()
        {
            Console.WriteLine("Informe  a diferença de fuso horário");
            int fusoHorario = Convert.ToInt32(Console.ReadLine());
            if (fusoHorario < -5 && fusoHorario > 5)
            {
                throw new Exception("Fuso Horario deve ser maior ou igual a -5 e menor ou igual a 5");
            }
            return fusoHorario;
        }
    }
}

