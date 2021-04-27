using System;

namespace GestaoDeEquipamento.ConsoleApp.OO
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            while (true)
            {
                MostrarMenuPrincipal();
                string opcao = Console.ReadLine().ToUpper();
                Console.Clear();
                ValidaOpcaoMenuPrincipal(opcao);

                if (opcao == "1")
                {
                    while (true)
                    {
                        Console.Clear();

                        MostrarMenuOpcoes();
                        opcao = Console.ReadLine().ToUpper();

                        Equipamento equipamento = new Equipamento(contador);

                        switch (opcao)
                        {
                            case "1": equipamento.AdicionaEquipamento(); break;
                            case "2": equipamento.VisualizaEquipamento(); break;
                            case "3": equipamento.EditaEquipamento(); break;
                            case "4": equipamento.ExcluiEquipamento(); break;
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
                else if (opcao == "2")
                {
                    while (true)
                    {
                        Console.Clear();

                        MostrarMenuOpcoes();
                        opcao = Console.ReadLine().ToUpper();

                        Chamado chamado = new Chamado(contador);

                        switch (opcao)
                        {
                            case "1": chamado.AdicionaChamado(); break;
                            case "2": chamado.VisualizaChamado(); break;
                            case "3": chamado.EditaChamado(); break;
                            case "4": chamado.ExcluiChamado(); break;
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
