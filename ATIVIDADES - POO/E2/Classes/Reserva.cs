using ATIVIDADES___POO.E2.interfaces;
using System;

namespace ATIVIDADES___POO.E2
{
    public class Reserva : AbstractReserva
    {
        public Reserva(ICliente cliente, IQuarto quarto, DateTime dataCheckIn, DateTime dataCheckOut, IFuncionario recepcionista)
            : base(cliente, quarto, dataCheckIn, dataCheckOut, recepcionista)
        { }

        public override decimal CalcularValorTotal()
        {
            int dias = (DataCheckOut - DataCheckIn).Days;
            return dias * Quarto.PrecoBase;
        }
    }
}