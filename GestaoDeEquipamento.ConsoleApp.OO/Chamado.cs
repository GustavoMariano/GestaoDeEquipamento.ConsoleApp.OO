using System;

namespace GestaoDeEquipamento.ConsoleApp.OO
{
    class Chamado
    {
        private string tituloChamado, descricaoChamado, equipamentoChamado;
        private DateTime dataAberturaChamado;
        private int idChamado;

        public Chamado(int idChamado)
        {
            this.idChamado = idChamado;
        }

        public void AdicionaChamado()
        {
            Console.Clear();

            while (true)
            {
                Console.WriteLine("Digite o titulo do equipamento");
                tituloChamado = Console.ReadLine();
                if (ValidaNulo(tituloChamado))
                {
                    Console.WriteLine("O chamado deve ter um titulo, tente novamente!!");
                    Console.ReadLine();
                    continue;
                }
                else
                    break;
            }

            while (true)
            {
                Console.WriteLine("Digite a descrição do chamado");
                descricaoChamado = Console.ReadLine();
                if (ValidaNulo(descricaoChamado))
                {
                    Console.WriteLine("O chamado deve ter uma descrição, tente novamente!!");
                    Console.ReadLine();
                    continue;
                }
                else
                    break;
            }

            while (true)
            {
                Console.WriteLine("Digite o equipamento do chamado");
                equipamentoChamado = Console.ReadLine();
                if (ValidaNulo(equipamentoChamado))
                {
                    Console.WriteLine("O chamado deve possuir um equipamento, tente novamente!!");
                    Console.ReadLine();
                    continue;
                }
                else
                    break;
            }

            while (true)
            {
                Console.WriteLine("Digite a data de abertura do chamado");
                bool verificaData = ValidaData();
                if (verificaData == false)
                {
                    Console.WriteLine("O chamado deve ter uma data de abertura válida, tente novamente!!");
                    Console.ReadLine();
                    continue;
                }
                break;
            }

            Console.Clear();

            Console.WriteLine($"{this.tituloChamado} {this.descricaoChamado} {this.equipamentoChamado} {this.dataAberturaChamado}");
        }

        public void VisualizaChamado()
        {
            string auxNumSerie;
            Console.Clear();

            Console.WriteLine("Digite o numero de série do equipamento que deseja visualizar");
            auxNumSerie = (Console.ReadLine());
        }

        public void EditaChamado()
        {
            Console.WriteLine("Edita Equipamento");
        }

        public void ExcluiChamado()
        {
            Console.WriteLine("Exclui Equipamento");
        }

        private bool ValidaData()
        {
            return DateTime.TryParse(Console.ReadLine(), out this.dataAberturaChamado);
        }

        private bool ValidaNulo(string atributo)
        {
            return atributo.Length < 0;
        }
    }
}
