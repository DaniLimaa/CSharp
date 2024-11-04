using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class ex5
    {
        public void AprovadoRecuperacaoReprovado()
        {
            Console.Clear();
            Console.WriteLine("Verificar se o aluno foi aprovado, ficou de recuperação ou foi reprovado");
            Console.WriteLine("Digite a nota");
            double nota = Convert.ToDouble(Console.ReadLine());

            if (nota >= 7)
            {
                Console.WriteLine("Foi aprovado");
            }
            else if (nota >= 5)
            {
                Console.WriteLine("Está de recuperação");
            }
            else
            {
                Console.WriteLine("Está reprovado");
            }
            Thread.Sleep(2000);

            cabecalho cabecalho = new cabecalho();
            cabecalho.Cabecalho();

            opcoesMenu opcoesMenu = new opcoesMenu();
            opcoesMenu.OpcoesMenu();
        }
    }
}
