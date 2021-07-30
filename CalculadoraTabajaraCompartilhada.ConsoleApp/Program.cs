using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTabajaraCompartilhada.ConsoleApp
{
    class Program
    {
        #region Requisito 01 [OK]
        //Nossa calculadora deve ter a possibilidade de somar dois números
        //marcos
        #endregion

        #region Requisito 02 [OK]
        //Nossa calculadora deve ter a possibilidade fazer várias operações de soma
        //marcos
        #endregion

       
        static void Main(string[] args)
        {
            string opcao = "";
            while (true)
            {
                //1.5.1 app 1 verão 5 correção de bug 1
                Console.WriteLine("Calculador 1.5.1");
                Console.WriteLine("Digite 1 para somar");
                Console.WriteLine("Digite S para sair");
                opcao = Console.ReadLine();
                if (opcao != "1" && opcao != "S")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida Tente novamente");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                double segundoNumero, primeiroNumero;

                Console.WriteLine("Digite o primeiro número");

                double.TryParse(Console.ReadLine(), out primeiroNumero);

                Console.WriteLine("Digite o segundo número");

                double.TryParse(Console.ReadLine(), out segundoNumero);
                double resultado = 0;
                resultado = primeiroNumero + segundoNumero;
                Console.WriteLine("Resultado: " + resultado);
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
