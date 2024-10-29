using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace aula2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            ExibirCabecalho();
            ExibirOpcoesMenu();

        }

            public static void ExibirCabecalho()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("-------------------------");
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("\nAutor: Daniel Camargo\n");
                Console.WriteLine("-------------------------");
                Console.WriteLine(@"
█▀ █▀▀ █▄░█ ▄▀█ █▀▀ ▄▄ ▄▀█ █▀▄▀█ █▀▀ █▀█ █ █▀▀ ▄▀█ █▄░█ ▄▀█
▄█ ██▄ █░▀█ █▀█ █▄▄ ░░ █▀█ █░▀░█ ██▄ █▀▄ █ █▄▄ █▀█ █░▀█ █▀█");
                Console.WriteLine("");
                Console.ResetColor();
                ExibirOpcoesMenu();
            }
        
        public static void ExibirOpcoesMenu()
        {
            Console.WriteLine("\nDigite 1 para registrar informações");
            Console.WriteLine("\nDigite 2 para listar informações");
            Console.WriteLine("\nDigite 3 para apagar informações");
            Console.WriteLine("\nDigite 0 para sair");
            Console.WriteLine("\nDigite a opção escolhida: ");
            int opcaoEscolhidaNumero = int.Parse(Console.ReadLine());
            //int opcaoEscolhidaNumero = int.Parse(opcaoEscolhida);
            /*
            if (opcaoEscolhidaNumero == 1)
            {
                Console.WriteLine("\nVoce escolheu a Opção 1");
            }
            if (opcaoEscolhidaNumero == 1)
            {
                Console.WriteLine("\nVoce escolheu a Opção 1");
            }*/

            switch (opcaoEscolhidaNumero)
            {
                case 1:
                    CadInfo();
                    break;

                case 2:
                    Console.WriteLine("\nVocê escolheu a Opção 2");
                    Thread.Sleep(3000);
                    Console.Clear();
                    ExibirCabecalho();
                    ExibirOpcoesMenu();
                    break;

                case 3:
                    Console.WriteLine("\nVocê escolheu a Opção 3");
                    Thread.Sleep(3000);
                    Console.Clear();
                    ExibirCabecalho();
                    ExibirOpcoesMenu();
                    break;

                case 0:
                    Console.Clear();
                    Console.WriteLine(@"
░██████╗░█████╗░██╗███╗░░██╗██████╗░░█████╗░
██╔════╝██╔══██╗██║████╗░██║██╔══██╗██╔══██╗
╚█████╗░███████║██║██╔██╗██║██║░░██║██║░░██║
░╚═══██╗██╔══██║██║██║╚████║██║░░██║██║░░██║
██████╔╝██║░░██║██║██║░╚███║██████╔╝╚█████╔╝
╚═════╝░╚═╝░░╚═╝╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝░");
                    Thread.Sleep(3000);
                    break;

                default:
                    Console.WriteLine("\nVoce digitou a opção invalida");
                    Thread.Sleep(3000);
                    Console.Clear();
                    ExibirCabecalho();
                    ExibirOpcoesMenu();
                    break;

            }
        }

private static void CadInfo()
        {
            Console.Clear();
            Console.WriteLine("Cadastro de Cliente");
            Console.WriteLine("Digite seu lindo nome");
            string NomeDoUsuario = Console.ReadLine();
            Console.WriteLine($"\n Nome Cadastrado com Sucesso!!! {NomeDoUsuario}");
            Thread.Sleep(3000);
            ExibirCabecalho();
            ExibirOpcoesMenu();

        }

    }
}
