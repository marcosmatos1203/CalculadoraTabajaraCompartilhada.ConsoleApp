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

        #region Requisito 04 [OK]
        //Nossa calculadora deve ter a possibilidade fazer as quatro operações básicas da matemática
        //marcos
        #endregion

        #region Requisito Funcional 05 [OK]
        //Nossa calculadora deve validar a opções do menu [OK]
        //Rafa
        #endregion

        #region BUG 01 [OK]
        //Nossa calculadora deve realizar as operações com "0"
        //Rafa
        #endregion

        #region Requisito 06
        /** Nossa calculadora deve permitir visualizar as operações já realizadas
         *  Critérios:
         *      1 - A descrição da operação realizada deve aparecer assim, exemplo:
         *          2 + 2 = 4
         *          10 - 5 = 5
         *          
         * marcos
         */
        #endregion

        #region Requisto Não Funcional 01
        //Todas as funcionalidades implementadas,
        //precisamos melhorar o entendimento do nosso código
        //Rafa e Marcos
        #endregion


        static void Main(string[] args)
        {

            string[] operacoesRealizadas = new string[100];
            int contadorOperacoes = 0;
            string opcao = "";

            while (true)
            {
                //1.5.1 app 1 verão 5 correção de bug 1
                Menu();

                opcao = Console.ReadLine();
                if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5" && opcao != "s" && opcao != "S")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida Tente novamente");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                if (opcao == "5")
                {
                    Console.Clear();
                    ApresentaOperacoesRealizadas();
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                double segundoNumero, primeiroNumero;

                Console.Write("Digite o primeiro número: ");

                double.TryParse(Console.ReadLine(), out primeiroNumero);


                do
                {
                    Console.Write("Digite o segundo número: ");
                    double.TryParse(Console.ReadLine(), out segundoNumero);
                    if (opcao == "4" && segundoNumero == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Impossível dividir por Zero");
                        Console.ResetColor();
                    }

                } while (opcao == "4" && segundoNumero == 0);

                string simboloOperacao = "";
                string operacaoRealizada = "";
                double resultado = 0;

                switch (opcao)
                {
                    case "1": resultado = primeiroNumero + segundoNumero; break;

                    case "2": resultado = primeiroNumero - segundoNumero; break;
                    case "3": resultado = primeiroNumero * segundoNumero; break;
                    case "4": resultado = primeiroNumero / segundoNumero; break;

                    default:
                        break;
                }
                switch (opcao)
                {
                    case "1": simboloOperacao = " + "; break;
                    case "2": simboloOperacao = " - "; break;
                    case "3": simboloOperacao = " * "; break;
                    case "4": simboloOperacao = " / "; break;
                    default: break;
                }
                void ApresentaOperacoesRealizadas()
                {
                    Console.WriteLine("Histórico");
                    Console.WriteLine("");
                    for (int i = 0; i < contadorOperacoes; i++)
                    {
                        Console.WriteLine(operacoesRealizadas[i]);
                    }
                }
                operacaoRealizada = $"{primeiroNumero} {simboloOperacao} {segundoNumero} = {resultado}";
                operacoesRealizadas[contadorOperacoes] = operacaoRealizada;
                contadorOperacoes++;
                Console.WriteLine("Resultado: " + resultado);
                Console.ReadLine();
                Console.Clear();
            }
        }

        private static void Menu()
        {
            Console.WriteLine("Calculadora 1.5.1");
            Console.WriteLine("Digite 1 para somar");
            Console.WriteLine("Digite 2 para subtrair");
            Console.WriteLine("Digite 3 para multiplicar");
            Console.WriteLine("Digite 4 para dividir");
            Console.WriteLine("Digite 5 para visualizar as operações");
            Console.WriteLine("Digite S para sair");
        }
    }
}
