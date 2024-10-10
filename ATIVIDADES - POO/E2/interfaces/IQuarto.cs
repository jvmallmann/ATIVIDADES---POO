namespace ATIVIDADES___POO.E2.interfaces
{
    public interface IQuarto
    {
        int Numero { get; set; }
        string Tipo { get; set; }
        decimal PrecoBase { get; set; }
        bool Disponivel { get; set; }

        void ExibirInformacoes();
    }
}
