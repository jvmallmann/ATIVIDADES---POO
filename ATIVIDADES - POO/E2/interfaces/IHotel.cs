using System.Collections.Generic;

namespace ATIVIDADES___POO.E2.interfaces
{
    public interface IHotel
    {
        string Nome { get; set; }
        string Endereco { get; set; }
        List<IQuarto> Quartos { get; set; }
        List<IReserva> Reservas { get; set; }
        List<IFuncionario> Funcionarios { get; set; }

        void AdicionarQuarto(IQuarto quarto);
        void AdicionarReserva(IReserva reserva);
        void AdicionarFuncionario(IFuncionario funcionario);
        void ExibirInformacoes();
    }
}
