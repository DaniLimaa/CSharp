using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RoupaBox
{
    internal class Menu
    {
        public void exibirMenu()
        {
            Console.WriteLine("\nDigite 0 para Sair");
            Console.WriteLine("\nDigite 1 Cadastro de Clientes");
            Console.WriteLine("\nDigite 2 Listar Clientes");
            Console.WriteLine("\nDigite 3 Cadastro de Produtos");
            Console.WriteLine("\nDigite 4 Listar Produtos");
            Console.WriteLine("\nEscolha uma opçao");
            int opcoesMenu = int.Parse(Console.ReadLine());

            switch (opcoesMenu)
            {
                case 0:

                    break;
                    
                case 1:
                    CadastroCli cadastroCli = new CadastroCli();
                    cadastroCli.cadClientes();
                    break;

                case 2:
                    break;

                case 3:
                    CadastroPro cadastroPro = new CadastroPro();
                    cadastroPro.cadProdutos();
                    break;

                case 4:
                    break;

                default:
                    Console.WriteLine("\nOpção invalida tente novamente");
                    Thread.Sleep(2000);
                    Console.Clear();
                    exibirMenu();
                    break;
            }

        }
    }
}
