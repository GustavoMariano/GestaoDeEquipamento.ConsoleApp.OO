using System;

namespace GestaoDeEquipamento.ConsoleApp.OO
{
    class Controladora
    {
        #region Variaveis auxiliares
        int auxArrayInt = 0;
        string auxArrayString = "";
        #endregion

        public Controladora(int auxArrayInt)
        {
            this.auxArrayInt = auxArrayInt;
        }

        #region Variaveis construtor chamado
        string tituloChamadoConstrutor, descricaoChamadoConstrutor, equipamentoChamadoConstrutor;
        DateTime dataAberturaChamadoConstrutor;
        #endregion

        #region Variaveis construtor equipamento 
        string nomeEquipamentoConstrutor, fabricanteEquipamentoConstrutor, numSerieEquipamentoConstrutor;
        double precoAquisicaoEquipamentoConstrutor;
        DateTime dataAquisicaoEquipamentoConstrutor;
        #endregion

        #region Arrays criados
        private Equipamento[] arrayEquipamentos = new Equipamento[10];
        private Chamado[] arrayChamados = new Chamado[10];
        #endregion

        #region Chamados

        #region Adicionar [OK]
        public void AdicionaChamado()
        {
            Console.Clear();

            for (int i = 0; i < arrayChamados.Length; i++)
            {
                if (arrayChamados[i] == null)
                {
                    auxArrayInt = i;
                    break;
                }
            }

            PreencherChamado();                       

            Chamado chamado = new Chamado(tituloChamadoConstrutor, descricaoChamadoConstrutor, equipamentoChamadoConstrutor, dataAberturaChamadoConstrutor);
            Console.Clear();
            Console.WriteLine("ID: " + auxArrayInt);
            Console.ReadLine();
            Console.Clear();
            arrayChamados[auxArrayInt] = chamado;
        }
        #endregion

        #region Visualizar [OK]
        public void VisualizaChamado()
        {
            Console.Clear();

            for (int i = 0; i < arrayChamados.Length; i++)
            {
                if (arrayChamados[i] != null)
                {
                    Console.WriteLine("ID: " + i);
                    arrayChamados[i].mostraDados();
                    Console.WriteLine("\n");
                }
            }
            Console.ReadLine();
            Console.Clear();
        }
        #endregion

        #region Editar [OK]
        public void EditaChamado()
        {
            Console.WriteLine("Digite o ID do chamado que deseja editar");
            int auxIdChamado = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            for (int i = 0; i < arrayChamados.Length; i++)
            {
                if (arrayChamados[i] != null && i == auxIdChamado)
                {
                    arrayChamados[i].mostraDados();
                    Console.WriteLine("\n");
                    auxArrayInt = i;

                    PreencherChamado();

                    Chamado chamado = new Chamado(tituloChamadoConstrutor, descricaoChamadoConstrutor, equipamentoChamadoConstrutor, dataAberturaChamadoConstrutor);
                    arrayChamados[auxIdChamado] = chamado;
                }
            }            
        }
        #endregion

        #region Excluir
        public void ExcluiChamado()
        {
            Console.WriteLine("Digite o ID do chamado que deseja excluir");
            auxArrayString = Console.ReadLine();

            arrayChamados[Convert.ToInt32(auxArrayString)] = null;

            Console.Clear();
        }
        #endregion

        #endregion

        #region Equipamentos

        #region Adicionar [OK]
        public void AdicionaEquipamento()
        {
            Console.Clear();

            for (int i = 0; i < arrayEquipamentos.Length; i++)
            {
                if (arrayEquipamentos[i] == null)
                {
                    auxArrayInt = i;
                    break;
                }
            }

            PreencherEquipamento();

            Console.Clear();

            Equipamento equipamento = new Equipamento(nomeEquipamentoConstrutor, fabricanteEquipamentoConstrutor, numSerieEquipamentoConstrutor, precoAquisicaoEquipamentoConstrutor, dataAquisicaoEquipamentoConstrutor);
            arrayEquipamentos[auxArrayInt] = equipamento;
        }


        #endregion

        #region Visualizar [OK]
        public void VisualizaEquipamento()
        {
            Console.Clear();

            for (int i = 0; i < arrayEquipamentos.Length; i++)
            {
                if (arrayEquipamentos[i] != null)
                {
                    arrayEquipamentos[i].mostraDados();
                    Console.WriteLine("\n");
                }
            }
            Console.ReadLine();
            Console.Clear();

        }
        #endregion

        #region Editar [OK]
        public void EditaEquipamento()
        {
            Console.WriteLine("Digite o numero de serie do equipamento que deseja editar");
            auxArrayString = Console.ReadLine();

            for (int i = 0; i < arrayEquipamentos.Length; i++)
            {
                if (arrayEquipamentos[i] != null && arrayEquipamentos[i].NumSerieEquipamento == auxArrayString)
                {
                    arrayEquipamentos[i].mostraDados();
                    Console.WriteLine("\n");
                    auxArrayInt = i;
                }
            }

            PreencherEquipamento();

            Equipamento equipamento = new Equipamento(nomeEquipamentoConstrutor, fabricanteEquipamentoConstrutor, numSerieEquipamentoConstrutor, precoAquisicaoEquipamentoConstrutor, dataAquisicaoEquipamentoConstrutor);
            arrayEquipamentos[auxArrayInt] = equipamento;
        }
        #endregion

        #region Excluir [OK]
        public void ExcluiEquipamento()
        {
            Console.Clear();

            Console.WriteLine("Digite numero de série do equipamento que deseja excluir");
            auxArrayString = Console.ReadLine();

            for (int i = 0; i < arrayEquipamentos.Length; i++)
            {
                if (arrayEquipamentos[i] != null && arrayEquipamentos[i].NumSerieEquipamento == auxArrayString)
                {
                    arrayEquipamentos[i] = null;
                }
            }

            Console.Clear();

        }
        #endregion

        #endregion

        private bool ValidaDataChamado()
        {
            return DateTime.TryParse(Console.ReadLine(), out this.dataAberturaChamadoConstrutor);
        }

        private bool ValidaDataEquipamento()
        {
            return DateTime.TryParse(Console.ReadLine(), out this.dataAquisicaoEquipamentoConstrutor);
        }

        private bool ValidaNulo(string atributo)
        {
            return atributo.Length <= 0;
        }

        private bool ValidaNome(string nome)
        {
            return nome.Length < 6;
        }

        private bool ValidaPreco(double preco)
        {
            return preco < 0;
        }

        private void PreencherChamado()
        {
            while (true)
            {
                Console.WriteLine("Digite o titulo do chamado");
                tituloChamadoConstrutor = Console.ReadLine();
                if (ValidaNulo(tituloChamadoConstrutor))
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
                descricaoChamadoConstrutor = Console.ReadLine();
                if (ValidaNulo(descricaoChamadoConstrutor))
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
                equipamentoChamadoConstrutor = Console.ReadLine();
                if (ValidaNulo(equipamentoChamadoConstrutor))
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
                bool verificaData = ValidaDataChamado();
                if (verificaData == false)
                {
                    Console.WriteLine("O chamado deve ter uma data de abertura válida, tente novamente!!");
                    Console.ReadLine();
                    continue;
                }
                break;
            }
        }

        private void PreencherEquipamento()
        {
            Console.Clear();

            while (true)
            {
                Console.WriteLine("Digite o nome do equipamento");
                nomeEquipamentoConstrutor = Console.ReadLine();
                if (ValidaNome(nomeEquipamentoConstrutor))
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
                fabricanteEquipamentoConstrutor = Console.ReadLine();
                if (ValidaNulo(fabricanteEquipamentoConstrutor))
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
                precoAquisicaoEquipamentoConstrutor = Convert.ToDouble(Console.ReadLine());
                if (ValidaPreco(precoAquisicaoEquipamentoConstrutor))
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
                numSerieEquipamentoConstrutor = Console.ReadLine();
                if (ValidaNulo(numSerieEquipamentoConstrutor))
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
                bool verificaData = ValidaDataEquipamento();
                if (verificaData == false)
                {
                    Console.WriteLine("O equipamento deve ter uma data de fabricação válida, tente novamente!!");
                    Console.ReadLine();
                    continue;
                }
                break;
            }
            Console.Clear();
        }
    }
}