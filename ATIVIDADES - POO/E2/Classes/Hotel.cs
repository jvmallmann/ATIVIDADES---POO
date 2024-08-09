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

        // Implementação das propriedades da interface
        List<IQuarto> IHotel.Quartos { get; set; }
        List<IReserva> IHotel.Reservas { get; set; }
        List<IFuncionario> IHotel.Funcionarios { get; set; }

        // Propriedades privadas para armazenamento
        private List<IQuarto> Quartos;
        private List<IReserva> Reservas;
        private List<IFuncionario> Funcionarios;

        public Hotel(string nome, string endereco)
        {
            Nome = nome;
            Endereco = endereco;
            Quartos = new List<IQuarto>();
            Reservas = new List<IReserva>();
            Funcionarios = new List<IFuncionario>();
        }

        public void AdicionarQuarto(IQuarto quarto)
        {
            Quartos.Add(quarto);
        }

        public void AdicionarReserva(IReserva reserva)
        {
            Reservas.Add(reserva);
        }

        public void AdicionarFuncionario(IFuncionario funcionario)
        {
            Funcionarios.Add(funcionario);
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Hotel: {Nome}, Endereço: {Endereco}");
            Console.WriteLine("\nFuncionários:\n");
            if (Funcionarios.Count > 0)
            {
                foreach (var funcionario in Funcionarios)
                {
                    funcionario.ExibirInformacoes();
                }
            }
            else
            {
                Console.WriteLine("Nenhum funcionário registrado.");
            }
            Console.WriteLine("\nQuartos:\n");
            foreach (var quarto in Quartos)
            {
                quarto.ExibirInformacoes();
            }
            Console.WriteLine("\nReservas:\n");
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
