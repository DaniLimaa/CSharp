using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class ex6
    {
        public void DiasMeses()
        {
            Console.Clear();
            Console.WriteLine("Verificar quantos dias tem o mês");
            Console.WriteLine("Escreva o numero do mês");
            int mes = Convert.ToInt32(Console.ReadLine());

            if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
            {
                Console.WriteLine("Tem 31 dias");
            }
            else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                Console.WriteLine("Tem 30 dias");
            }
            else if (mes == 2)
            {
                Console.WriteLine("Tem 28 dias (se o ano for bissexto tem 29 dias)");
            }
            else
            {
                Console.WriteLine("Mes invalido, digite um numero entre 1 e 12");
                return;
            }
            Thread.Sleep(2000);

            cabecalho cabecalho = new cabecalho();
            cabecalho.Cabecalho();

            opcoesMenu opcoesMenu = new opcoesMenu();
            opcoesMenu.OpcoesMenu();
        }
    }
}
