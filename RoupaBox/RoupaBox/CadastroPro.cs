using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoupaBox
{
    internal class CadastroPro
    {
        public void cadProdutos()
        {
            Console.Clear();
            Console.WriteLine("Cadastro Produtos");
            Console.WriteLine("\nDigite a marca do produto");
            string marcaPro = Console.ReadLine();
            Console.WriteLine("\nDigite o tamanho do produto");
            string tamPro = Console.ReadLine();
            Console.WriteLine("\nDigite a cor do produto");
            string corPro = Console.ReadLine();
            Console.WriteLine("\nDigite a categoria do produto");
            string catPro = Console.ReadLine();
            Console.WriteLine("\nDigite a descrição do produto");
            string descPro = Console.ReadLine();
            Console.WriteLine("\nDigite o valor do produto");
            double valPro = double.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o peso do produto");
            double pesoPro = double.Parse(Console.ReadLine());
            Console.WriteLine("Produto cadastrado com secesso");
        }
    }
}
