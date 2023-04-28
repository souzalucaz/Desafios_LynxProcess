using System;

namespace Desafio01
{
    class Program
    {
        static void Main()
        {
            /*Leia 3 valores, no caso, variáveis A, B e C, que são as três notas de um aluno. 
             * A seguir, calcule a média do aluno, sabendo que a nota A tem peso 2, a nota B tem peso 3 e a nota C tem peso 5. 
             * Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.
             
            Entrada
            O arquivo de entrada contém 3 valores com uma casa decimal, de dupla precisão (double).

            Saída
            Imprima a variável MEDIA conforme exemplo abaixo, com 1 dígito após o ponto decimal e com um espaço em branco antes e depois da igualdade. 
            Assim como todos os problemas, não esqueça de imprimir o fim de linha após o resultado, caso contrário, você receberá "Presentation Error".
             */
            try
            {
                double notaA = ObterNota("Digite o valor da primeira nota: ");
                double notaB = ObterNota("Digite o valor da segunda nota: ");
                double notaC = ObterNota("Digite o valor da terceira nota: ");
                Console.WriteLine($"MEDIA = {ObterMedia(notaA, notaB, notaC)}");
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }
        }

        static double ObterNota(string mensagem)
        {
            Console.WriteLine(mensagem);
            double nota = Convert.ToDouble(Console.ReadLine());
            if (nota < 0 || nota > 10)
            {
                throw new Exception("Nota inválida, nota deve ser maior que 0 e menor que 10");

            }
            return nota;
        }
        static double ObterMedia(double notaA, double notaB, double notaC)
        {
            return ((notaA * 2) + (notaB * 3) + (notaC * 5)) / 10;
        }
    }

}
