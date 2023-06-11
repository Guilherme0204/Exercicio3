using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace FaixaEtária
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random sorte = new Random();
            double[] faixa = new double[4] { 0, 1, 2, 3 };
            int pessoas = 999;
            int idade;
            for (int i = 0; i < pessoas; i++)
            {
                idade = sorte.Next(1, 100);
                if (idade <=20)
                {
                    faixa[0] = faixa[0] + 1;
                    
                }
                else if (idade >= 21 && idade <= 50)
                {
                    faixa[1] = faixa[1] + 1;
                }
                else if (idade >= 51 && idade <= 70)
                {
                    faixa[2] = faixa[2] + 1;
                }
                else 
                {
                    faixa[3] = faixa[3] + 1;
                }

            }
            double porcentagem1, porcentagem2, porcentagem3, porcentagem4; 
            porcentagem1 = (faixa[0] /pessoas) * 100;
            porcentagem2 = (faixa[1] / pessoas) * 100;
            porcentagem3 = (faixa[2] / pessoas) * 100;
            porcentagem4 = (faixa[3] / pessoas) * 100;
            Console.WriteLine($"Nessa faixa etária se encontra {faixa[0]} pessoas e o percentual em relação ao total é de {porcentagem1.ToString("N2")}%");
            Console.WriteLine($"Nessa faixa etária se encontra {faixa[1]} pessoas e o percentual em relação ao total é de {porcentagem2.ToString("N2")}%");
            Console.WriteLine($"Nessa faixa etária se encontra {faixa[2]} pessoas e o percentual em relação ao total é de {porcentagem3.ToString("N2")}%");
            Console.WriteLine($"Nessa faixa etária se encontra {faixa[3]} pessoas e o percentual em relação ao total é de {porcentagem4.ToString("N2")}%");

            Console.ReadKey();

    


        }
    }
}
