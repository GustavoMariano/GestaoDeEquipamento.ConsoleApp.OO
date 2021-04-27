using System;

namespace GestaoDeEquipamento.ConsoleApp.OO
{
    class Program
    {
        static void Main(string[] args)
        {
            Controladora controladora = new Controladora(0);
            while (true)
            {
                MostrarMenuPrincipal();
                string opcao = Console.ReadLine().ToUpper();
                Console.Clear();
                ValidaOpcaoMenuPrincipal(opcao);

                if (EhOpcao("1",opcao))
                {
                    while (true)
                    {
                        Console.Clear();

                        MostrarMenuOpcoes();
                        opcao = Console.ReadLine().ToUpper();

                        switch (opcao)
                        {
                            case "1": controladora.AdicionaEquipamento(); break;
                            case "2": controladora.VisualizaEquipamento(); break;
                            case "3": controladora.EditaEquipamento(); break;
                            case "4": controladora.ExcluiEquipamento(); break;
                            case "S": Environment.Exit(0); break;
                            default:
                                Console.Clear();
                                MensagemEmVermelho("Opção inválida, tente novamente!!");
                                Console.ReadLine();
                                continue;
                        }
                        break;
                    }
                }

                else if (EhOpcao("2", opcao))
                {
                    while (true)
                    {
                        Console.Clear();

                        MostrarMenuOpcoes();
                        opcao = Console.ReadLine().ToUpper();

                        switch (opcao)
                        {
                            case "1": controladora.AdicionaChamado(); break;
                            case "2": controladora.VisualizaChamado(); break;
                            case "3": controladora.EditaChamado(); break;
                            case "4": controladora.ExcluiChamado(); break;
                            case "S": Environment.Exit(0); break;
                            default:
                                Console.Clear();
                                MensagemEmVermelho("Opção inválida, tente novamente!!");
                                Console.ReadLine();
                                continue;
                        }
                        break;
                    }
                }
            }
        }
        private static bool EhOpcao(string num, string opcao)
        {
            return opcao == num;
        }

        private static void ValidaOpcaoMenuPrincipal(string opcao)
        {
            switch (opcao)
            {
                case "S": Environment.Exit(0); break;
                case "1": break;
                case "2": break;
                default:
                    MensagemEmVermelho("Opção inválida, tente novamente!!"); Console.ReadLine();
                    break;
            }
        }

        private static void MostrarMenuPrincipal()
        {
            Console.WriteLine("1 para equipamentos, 2 para chamados");
            MensagemEmVermelho("S PARA SAIR");
        }

        private static void MostrarMenuOpcoes()
        {
            Console.WriteLine("1 para adicionar \n2 para visualizar \n3 para editar \n4 para excluir");
            MensagemEmVermelho("S PARA SAIR");
        }

        private static void MensagemEmVermelho(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ResetColor();
        }
    }
}