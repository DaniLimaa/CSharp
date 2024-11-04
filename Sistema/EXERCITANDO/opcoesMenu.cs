using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class opcoesMenu
    {
        public void OpcoesMenu()
        {
            Console.WriteLine("\nExercio 1: Verificar se um numero é positivo, negativo ou zero\n");
            Console.WriteLine("\nDigite 02: Informar se uma pessoa é maior de idade ou nâo\n");
            Console.WriteLine("\nDigite 03: Verificar se um numero é impar ou par\n");
            Console.WriteLine("\nDigite 04: Verificar se a letra é uma vogal ou uma consoante\n");
            Console.WriteLine("\nDigite 05: Verificar se o aluno esta aprovado, de recuperação ou reprovado\n");
            Console.WriteLine("\nDigite 06: Verificar quantos dias tem os meses\n");
            Console.WriteLine("\nDigite 07: Converter reais para dolar, euro e libra esterlina\n");
            Console.WriteLine("\nDigite 08: Verificar se a pessoa pode votar e dirigir\n");
            Console.WriteLine("\nDigite 00 para sair\n");
            Console.WriteLine("\nEscolha uma opção\n");
            int Opcoesmenu = int.Parse(Console.ReadLine());

            switch (Opcoesmenu)
            {
                case 1:
                    ex1 ex1 = new ex1();
                    ex1.VerificarNumero();
                    break;
                case 2:
                    ex2 ex2 = new ex2();
                    ex2.VerificarIdade();
                    break;
                case 3:
                    ex3 ex3 = new ex3();
                    ex3.NumeroParOuImpar();
                    break;
                case 4:
                    ex4 ex4 = new ex4();
                    ex4.VogalOuConsoante();
                    break;
                case 5:
                    ex5 ex5 = new ex5();
                    ex5.AprovadoRecuperacaoReprovado();
                    break;
                case 6:
                    ex6 ex6 = new ex6();
                    ex6.DiasMeses();
                    break;
                case 7:
                    ex7 ex7 = new ex7();
                    ex7.DolarEuroLibra();
                    break;
                case 8:
                    ex8 ex8 = new ex8();
                    ex8.VotarDirigir();
                    break;
            }
        }
    }
}
