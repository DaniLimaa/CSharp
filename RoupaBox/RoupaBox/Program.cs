using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace RoupaBox
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Cabecalho variavelCabecalho = new Cabecalho();
            variavelCabecalho.exibirCabecalho();

            Produtos varPro = new Produtos();
            Clientes varCli = new Clientes();


            ExibirMenu variavelMenu = new ExibirMenu();
            variavelMenu.Menu(varPro, varCli);

        }
    }
}
