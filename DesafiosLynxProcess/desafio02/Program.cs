using System;

namespace desafio02
{
    class Program
    {
        static void Main()
        {
            /*Faça um programa que calcule e mostre o volume de uma esfera sendo fornecido o valor de seu raio (R).
             * A fórmula para calcular o volume é: (4/3) * pi * R3. Considere (atribua) para pi o valor 3.14159.
             Entrada:
             O arquivo de entrada contém um valor de ponto flutuante (dupla precisão), correspondente ao raio da esfera.

             Saída
             A saída deverá ser uma mensagem "VOLUME" conforme o exemplo fornecido abaixo, com um espaço antes e um espaço depois da igualdade. 
               O valor deverá ser apresentado com 3 casas após o ponto.
             */

            Console.WriteLine("Insira o valor do raio da esfera");
            double valorRaio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("--------------");
            Console.WriteLine($"VOLUME = {ObterVolume(valorRaio)}");
        }
        static double ObterVolume(double valorRaio)
        {
            const double pi = 3.14159;
            double volume = (4 * pi * Math.Pow(valorRaio, 3)) / 3;
            return Math.Round(volume, 3);
        }
    }


}
