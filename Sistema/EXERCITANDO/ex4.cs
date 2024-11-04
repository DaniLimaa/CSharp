using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class ex4
    {
        public void VogalOuConsoante()
        {
            Console.Clear();
            Console.WriteLine("Verificar se a letra é vogal ou consoante");
            Console.WriteLine("Digite a letra");
            char letra = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
            {
                Console.WriteLine("A letra é uma vogal");
            }
            else
            {
                Console.WriteLine("A letra é uma consoante");
            }
            Thread.Sleep(2000);

            cabecalho cabecalho = new cabecalho();
            cabecalho.Cabecalho();

            opcoesMenu opcoesMenu = new opcoesMenu();
            opcoesMenu.OpcoesMenu();
        }
    }
}
