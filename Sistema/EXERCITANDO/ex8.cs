using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class ex8
    {
        public void VotarDirigir()
        {
            Console.Clear();
            Console.WriteLine("Verificar se uma pessoa pode votar e dirigir");
            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade");
            int idade = Convert.ToInt32(Console.ReadLine());

            bool podeDirigir = idade >= 18;
            bool podeVotar = idade >= 18;

            Console.WriteLine($"{nome}");
            if (podeVotar)
            {
                Console.WriteLine("Você pode votar");
            }
            else
            {
                Console.WriteLine("Você não pode votar");
            }
            if (podeDirigir)
            {
                Console.WriteLine("Você pode dirigir");
            }
            else
            {
                Console.WriteLine("Você não pode dirigir");
            }
            Thread.Sleep(2000);

            cabecalho cabecalho = new cabecalho();
            cabecalho.Cabecalho();

            opcoesMenu opcoesMenu = new opcoesMenu();
            opcoesMenu.OpcoesMenu();
        }
    }
}
