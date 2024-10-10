using ATIVIDADES___POO.E2.interfaces;
using System;
using System.Collections.Generic;

namespace ATIVIDADES___POO.E2
{
    public class Hotel : IHotel
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public List<IQuarto> Quartos { get; set; }
        public List<IReserva> Reservas { get; set; }
        public List<IFuncionario> Funcionarios { get; set; }

        public Hotel(string nome, string endereco, List<IQuarto> quartos, List<IReserva> reservas, List<IFuncionario> funcionarios)
        {
            Nome = nome;
            Endereco = endereco;
            Quartos = quartos;
            Reservas = reservas;
            Funcionarios = funcionarios;
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
            foreach (var funcionario in Funcionarios)
            {
                funcionario.ExibirInformacoes();
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
    }
}
