using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class ex3
    {
        public void NumeroParOuImpar()
        {
            Console.Clear();
            Console.WriteLine("Verificar se um numero é impar ou par");
            Console.WriteLine("Digite o numero");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O numero é par");
            }
            else
            {
                Console.WriteLine("O numero é impar");
            }
            Thread.Sleep(2000);

            cabecalho cabecalho = new cabecalho();
            cabecalho.Cabecalho();

            opcoesMenu opcoesMenu = new opcoesMenu();
            opcoesMenu.OpcoesMenu();
        }
    }
}
