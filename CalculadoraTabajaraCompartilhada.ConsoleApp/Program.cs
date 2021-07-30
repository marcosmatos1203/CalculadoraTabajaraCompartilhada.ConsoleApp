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

        #region Requisito Funcional 03 [OK]
        //Nossa calculadora deve ter a possibilidade fazer várias operações de soma e de subtração
        //Rafa
        #endregion

        static void Main(string[] args)
        {
            string opcao = "";
            while (true)
            {
                //1.5.1 app 1 verão 5 correção de bug 1
                Console.WriteLine("Calculadora 1.3");
                Console.WriteLine("Digite 1 para somar");
                Console.WriteLine("Digite 2 para subtrair");
                Console.WriteLine("Digite S para sair");
                opcao = Console.ReadLine();
                if (opcao != "1" && opcao != "S" && opcao != "s" && opcao != "2")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida Tente novamente");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                double segundoNumero, primeiroNumero;

                Console.Write("Digite o primeiro número: ");

                double.TryParse(Console.ReadLine(), out primeiroNumero);

                Console.Write("Digite o segundo número: ");

                double.TryParse(Console.ReadLine(), out segundoNumero);
                double resultado = 0;
                switch (opcao)
                {
                    case "1": resultado = primeiroNumero + segundoNumero; break;

                    case "2": resultado = primeiroNumero - segundoNumero; break;

                    default:
                        break;
                }
                Console.WriteLine("Resultado: " + resultado);
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
