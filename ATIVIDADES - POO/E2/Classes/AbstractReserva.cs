using ATIVIDADES___POO.E2.interfaces;
using System;

namespace ATIVIDADES___POO.E2
{
    public abstract class AbstractReserva : IReserva
    {
        public ICliente Cliente { get; set; }
        public IQuarto Quarto { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }
        public IFuncionario Recepcionista { get; set; }

        public AbstractReserva(ICliente cliente, IQuarto quarto, DateTime dataCheckIn, DateTime dataCheckOut, IFuncionario recepcionista)
        {
            Cliente = cliente;
            Quarto = quarto;
            DataCheckIn = dataCheckIn;
            DataCheckOut = dataCheckOut;
            Recepcionista = recepcionista;
        }

        public abstract decimal CalcularValorTotal();

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Cliente: {Cliente.Nome}, Quarto: {Quarto.Numero}, Check-In: {DataCheckIn.ToShortDateString()}, Check-Out: {DataCheckOut.ToShortDateString()}, Valor Total: {CalcularValorTotal():C}, Recepcionista: {Recepcionista.Nome}");
        }
    }
}
