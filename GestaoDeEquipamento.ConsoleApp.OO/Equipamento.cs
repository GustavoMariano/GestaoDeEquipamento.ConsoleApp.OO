using System;

namespace GestaoDeEquipamento.ConsoleApp.OO
{
    class Equipamento
    {
        private string nomeEquipamento, fabricanteEquipamento, numSerieEquipamento;
        private double precoAquisicaoEquipamento;
        private int contadorEquipamento;
        private DateTime dataAquisicaoEquipamento;

        public Equipamento(int contadorEquipamento)
        {
            this.contadorEquipamento = contadorEquipamento;
        }

        //public Equipamento(string nomeEquipamento, string fabricanteEquipamento, double precoAquisicaoEquipamento, string numSerieEquipamento, DateTime dataAquisicaoEquipamento)
        //{
        //    this.nomeEquipamento = nomeEquipamento;
        //    this.fabricanteEquipamento = fabricanteEquipamento;
        //    this.precoAquisicaoEquipamento = precoAquisicaoEquipamento;
        //    this.numSerieEquipamento = numSerieEquipamento;
        //}

        public void AdicionaEquipamento()
        {
            Console.Clear();

            while (true)
            {
                Console.WriteLine("Digite o nome do equipamento");
                nomeEquipamento = Console.ReadLine();
                if (ValidaNome(nomeEquipamento))
                {
                    Console.WriteLine("O nome deve ter no mínimo 6 caracteres, tente novamente!!");
                    Console.ReadLine();
                    continue;
                }
                else
                    break;
            }

            while (true)
            {
                Console.WriteLine("Digite o fabricante do equipamento");
                fabricanteEquipamento = Console.ReadLine();
                if (ValidaNulo(fabricanteEquipamento))
                {
                    Console.WriteLine("O equipamento deve ter um fabricante, tente novamente!!");
                    Console.ReadLine();
                    continue;
                }
                else
                    break;
            }

            while (true)
            {
                Console.WriteLine("Digite o preço de aquisição do equipamento");
                precoAquisicaoEquipamento = Convert.ToDouble(Console.ReadLine());
                if (ValidaPreco(precoAquisicaoEquipamento))
                {
                    Console.WriteLine("O equipamento deve possuir um valor de aquisição válido, tente novamente!!");
                    Console.ReadLine();
                    continue;
                }
                else
                    break;
            }

            while (true)
            {
                Console.WriteLine("Digite o numero de série do equipamento");
                numSerieEquipamento = Console.ReadLine();
                if (ValidaNulo(numSerieEquipamento))
                {
                    Console.WriteLine("O equipamento deve ter um numero de série válido, tente novamente!!");
                    Console.ReadLine();
                    continue;
                }
                else
                    break;
            }

            while (true)
            {
                Console.WriteLine("Digite a data de aquisição do equipamento");
                bool verificaData = ValidaData();
                if (verificaData == false)
                {
                    Console.WriteLine("O equipamento deve ter uma data de fabricação válida, tente novamente!!");
                    Console.ReadLine();
                    continue;
                }
                break;
            }

            Console.Clear();

            Console.WriteLine($"{this.nomeEquipamento} {this.fabricanteEquipamento} {this.precoAquisicaoEquipamento} {this.numSerieEquipamento} " +
                $"{this.dataAquisicaoEquipamento}");
        }

        private bool ValidaData()
        {
            return DateTime.TryParse(Console.ReadLine(), out this.dataAquisicaoEquipamento);
        }

        public void VisualizaEquipamento()
        {
            string auxNumSerie;
            Console.Clear();

            Console.WriteLine("Digite o numero de série do equipamento que deseja visualizar");
            auxNumSerie = (Console.ReadLine());


        }

        public void EditaEquipamento()
        {
            Console.WriteLine("Edita Equipamento");
        }

        public void ExcluiEquipamento()
        {
            Console.WriteLine("Exclui Equipamento");
        }


        private bool ValidaNome(string nome)
        {
            return nome.Length < 6;
        }

        private bool ValidaNulo(string atributo)
        {
            return atributo.Length < 0;
        }

        private bool ValidaPreco(double preco)
        {
            return preco < 0;
        }
    }
}
