using ATIVIDADES___POO.E2.interfaces;
using System;

namespace ATIVIDADES___POO.E2.Classes
{
    public class Reserva : IReserva
    {
        // Campos privados para encapsulamento
        private int id;
        private Cliente cliente;
        private IQuarto quarto;
        private DateTime dataCheckIn;
        private DateTime dataCheckOut;

        // Implementação explícita dos membros da interface IReserva
        int IReserva.Id
        {
            get { return id; }
            set { id = value; }
        }

        ICliente IReserva.Cliente
        {
            get { return cliente; }
            set { cliente = (Cliente)value; } // Casting para Cliente, se necessário
        }

        IQuarto IReserva.Quarto
        {
            get { return quarto; }
            set { quarto = value; }
        }

        DateTime IReserva.DataCheckIn
        {
            get { return dataCheckIn; }
            set { dataCheckIn = value; }
        }

        DateTime IReserva.DataCheckOut
        {
            get { return dataCheckOut; }
            set { dataCheckOut = value; }
        }

        // Construtor para inicializar a classe
        public Reserva(int id, Cliente cliente, IQuarto quarto, DateTime dataCheckIn, DateTime dataCheckOut)
        {
            this.id = id;
            this.cliente = cliente;
            this.quarto = quarto;
            this.dataCheckIn = dataCheckIn;
            this.dataCheckOut = dataCheckOut;
        }

        // Implementação do método da interface
        public decimal CalcularValorTotal()
        {
            int dias = (dataCheckOut - dataCheckIn).Days;
            return dias * quarto.PrecoBase;
        }

        // Implementação do método da interface
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Reserva ID: {id}, Cliente: {cliente.Nome}, Quarto: {quarto.Numero}, Check-In: {dataCheckIn.ToShortDateString()}, Check-Out: {dataCheckOut.ToShortDateString()}, Valor Total: {CalcularValorTotal():C}");
        }
    }
}
