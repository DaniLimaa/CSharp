using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoupaBox
{
    internal class CadastroCli
    {
        public void cadClientes()
        {
            Console.Clear();
            Console.WriteLine("Cadastro do Cliente");
            Console.WriteLine("\nDigite o nome completo do cliente");
            string nomeCli = Console.ReadLine();
            Console.WriteLine("\nDigite o cpf do cliente (deve conter exatos 11 numeros)");
            string cpfCli = Console.ReadLine();
            while (cpfCli.Length != 11 || !cpfCli.All(char.IsDigit))
            {
                Console.WriteLine("CPF invalido, tente novamente!");
                cpfCli = Console.ReadLine();
            }
            Console.WriteLine("\nDigite o numero de telefone do cliente");
            long telCli = long.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite a idade do cliente");
            int idadeCli = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o email do cliente");
            string mailCli = Console.ReadLine();
            while (!mailCli.Contains("@"))
            {
                Console.WriteLine("O endereço de email não é valido, tente novamente!");
                mailCli = Console.ReadLine();
            }
            Console.WriteLine("\nDigite o sexo do cliente");
            string sexoCli = Console.ReadLine();
            Console.WriteLine("\nDigite a rua do cliente");
            string ruaCli = Console.ReadLine();
            Console.WriteLine("\nDigite o complemento do cliente");
            string compCli = Console.ReadLine();
            Console.WriteLine("\nDigite o numero do cliente");
            int numCLi = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o bairro do cliente");
            string bairroCli = Console.ReadLine();
            Console.WriteLine("\nDigite a cidade do cliente");
            string cidCli = Console.ReadLine();
            Console.WriteLine("\nDigite o estado do cliente");
            string estCli = Console.ReadLine();
            Console.WriteLine("\nDigite o cep do cliente");
            long cepCli = long.Parse(Console.ReadLine());
            Console.WriteLine("\nCliente cadastradocom sucesso");
        }
    }
}
