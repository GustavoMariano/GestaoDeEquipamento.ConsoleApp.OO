using System;

namespace GestaoDeEquipamento.ConsoleApp.OO
{
    class Chamado
    {
        private string tituloChamado, descricaoChamado, equipamentoChamado;
        private DateTime dataAberturaChamado;

        public Chamado(string tituloChamado, string descricaoChamado, string equipamentoChamado, DateTime dataAberturaChamado)
        {
            this.tituloChamado = tituloChamado;
            this.descricaoChamado = descricaoChamado;
            this.equipamentoChamado = equipamentoChamado;
            this.dataAberturaChamado = dataAberturaChamado;
        }

        public void mostraDados()
        {
            Console.WriteLine("\nTitulo : " + tituloChamado + "\nEquipamento : " + equipamentoChamado + "\nData abertura : " + dataAberturaChamado.ToString("dd/MM/yyyy") + "\nDias em aberto : " + (DateTime.Now - dataAberturaChamado).ToString("dd"));
        }
    }
}
