using ATIVIDADES___POO.E2.interfaces;
using System;

namespace ATIVIDADES___POO.E2
{
    public class Funcionario : IFuncionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get;  set; }

        public Funcionario(string nome, string cpf, string endereco, string telefone, string cargo, decimal salario)
        {
            Nome = nome;
            CPF = cpf;
            Endereco = endereco;
            Telefone = telefone;
            Cargo = cargo;
            Salario = salario;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, Cargo: {Cargo},CPF: {CPF}, Telefone: {Telefone}");
        }
    }
}
