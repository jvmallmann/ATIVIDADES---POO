using System;

namespace ATIVIDADES___POO.E2.interfaces
{
    public interface IFuncionario
    {
        string Nome { get; set; }
        string CPF { get; set; }
        string Endereco { get; set; }
        string Telefone { get; set; }
        string Cargo { get; set; }
        decimal Salario { get; set; }

        void ExibirInformacoes();
    }
}
