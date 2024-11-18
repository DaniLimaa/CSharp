using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoupaBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cabecalho cabecalho = new cabecalho();
            cabecalho.exibirCabecalho();

           Menu menu = new Menu();
            menu.exibirMenu();

        }
    }
}
