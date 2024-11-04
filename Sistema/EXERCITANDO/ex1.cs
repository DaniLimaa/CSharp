using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class ex1
    {
        public void VerificarNumero()
        {
            Console.Clear();
            Console.WriteLine("Exericio 1: Verificar se um numero é positivo, negativo ou zero");
            Console.WriteLine("Digite um numero");
            double numero = Convert.ToDouble(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("O numero é positivo");
            }
            else if (numero == 0)
            {
                Console.WriteLine("O numero é zero");
            }
            else if (numero < 0)
            {
                Console.WriteLine("O numero é negativo");
            }
            Thread.Sleep(2000);
            
            cabecalho cabecalho = new cabecalho();
            cabecalho.Cabecalho();

            opcoesMenu opcoesMenu = new opcoesMenu();
            opcoesMenu.OpcoesMenu();

        }
    }
}
