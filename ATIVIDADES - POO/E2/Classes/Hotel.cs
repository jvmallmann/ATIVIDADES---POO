using ATIVIDADES___POO.E2.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ATIVIDADES___POO.E2
{
    public class Hotel : IHotel
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        List<IQuarto> IHotel.Quartos { get; set; }
        List<IReserva> IHotel.Reservas { get; set; }

        private List<IQuarto> Quartos;
        private List<IReserva> Reservas;
        private List<IPessoa> pessoas;

        public Hotel(string nome, string endereco)
        {
            Nome = nome;
            Endereco = endereco;
            Quartos = new List<IQuarto>();
            Reservas = new List<IReserva>();
            pessoas = new List<IPessoa>();
        }

        public void AdicionarQuarto(IQuarto quarto)
        {
            Quartos.Add(quarto);
        }

        public void AdicionarReserva(IReserva reserva)
        {
            Reservas.Add(reserva);
        }

        public void AdicionarPessoa(IPessoa pessoa)
        {
            pessoas.Add(pessoa);
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
                reserva.ExibirInformacoes();
            }
            
        }

        public IReserva ObterReserva(int idReserva)
        {
            throw new NotImplementedException();
        }
    }
}
