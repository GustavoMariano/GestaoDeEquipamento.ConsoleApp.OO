using System;

namespace GestaoDeEquipamento.ConsoleApp.OO
{
    class Equipamento
    {
        private string nomeEquipamento, fabricanteEquipamento, numSerieEquipamento;
        private double precoAquisicaoEquipamento;
        private DateTime dataAquisicaoEquipamento;

        public string NumSerieEquipamento { get => numSerieEquipamento; set => numSerieEquipamento = value; }

        public Equipamento(string nomeEquipamento, string fabricanteEquipamento, string numSerieEquipamento, double precoAquisicaoEquipamento, DateTime dataAquisicaoEquipamento)
        {
            this.nomeEquipamento = nomeEquipamento;
            this.fabricanteEquipamento = fabricanteEquipamento;
            this.numSerieEquipamento = numSerieEquipamento;
            this.precoAquisicaoEquipamento = precoAquisicaoEquipamento;
            this.dataAquisicaoEquipamento = dataAquisicaoEquipamento;
        }
                
        public void mostraDados()
        {
            Console.WriteLine("\nNome : " + nomeEquipamento + "\nNúmero de série : " + numSerieEquipamento + "\nPreço : " + precoAquisicaoEquipamento + "\nFabricante : " + fabricanteEquipamento + "\nData de Aquisição : " + dataAquisicaoEquipamento.ToString("dd/MM/yyyy"));
        }
    }
}