using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class ex2
    {
        public void VerificarIdade()
        {
            Console.Clear();
            Console.WriteLine("Verificar se uma pessoa é maior de idade ou não");
            Console.WriteLine("Digite a idade");
            double idade = Convert.ToDouble(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("É maior de idade");
            }
            else
            {
                Console.WriteLine("É menor de idade");
            }
            Thread.Sleep(2000);

            cabecalho cabecalho = new cabecalho();
            cabecalho.Cabecalho();

            opcoesMenu opcoesMenu = new opcoesMenu();
            opcoesMenu.OpcoesMenu();
        }
    }
}
