using ATIVIDADES___POO.E2.interfaces;
using System;
using System.Collections.Generic;

namespace ATIVIDADES___POO.E2.Classes
{
    public class Hotel : IHotel
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public List<IQuarto> Quartos { get; set; }
        public List<IReserva> Reservas { get; set; }

        public Hotel(string nome, string endereco)
        {
            Nome = nome;
            Endereco = endereco;
            Quartos = new List<IQuarto>();
            Reservas = new List<IReserva>();
        }

        public void AdicionarQuarto(IQuarto quarto)
        {
            Quartos.Add(quarto);
        }

        public void AdicionarReserva(IReserva reserva)
        {
            Reservas.Add(reserva);
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Hotel: {Nome}, Endereço: {Endereco}");
            Console.WriteLine("Quartos:");
            foreach (var quarto in Quartos)
            {
                quarto.ExibirInformacoes(); 
            }
            Console.WriteLine("Reservas:");
            foreach (var reserva in Reservas)
            {
                if (reserva is Reserva reservaConcreta)
                {
                    reservaConcreta.ExibirInformacoes();
                }
                else
                {
                    // Lidar com o caso onde reserva não é do tipo esperado
                    Console.WriteLine("Tipo de reserva desconhecido.");
                }
            }
        }
    }
}
