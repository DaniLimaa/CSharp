using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class ex7
    {
        public void DolarEuroLibra()
        {
            Console.Clear();

            const double taxaDolar = 5.81;
            const double taxaEuro = 6.33;
            const double taxaLibra = 7.53;

            Console.WriteLine("Converter real para dolarés, euros e libras esterlinas");
            Console.WriteLine("Digite o valor em real");
            double valorReais = Convert.ToDouble(Console.ReadLine());

            double ValorDolares = valorReais * taxaDolar;
            double ValorEuros = valorReais * taxaEuro;
            double ValorLibras = valorReais * taxaLibra;


            Console.WriteLine($"Valor em doláres: {ValorDolares:F2}");
            Console.WriteLine($"Valor em euros: {ValorEuros:F2}");
            Console.WriteLine($"Valor em libras: {ValorLibras:F2}");

            Thread.Sleep(2000);

            cabecalho cabecalho = new cabecalho();
            cabecalho.Cabecalho();

            opcoesMenu opcoesMenu = new opcoesMenu();
            opcoesMenu.OpcoesMenu();

        }
    }
}
