using ATIVIDADES___POO.E2.interfaces;
using System;

namespace ATIVIDADES___POO.E2
{
    public class Funcionario : IFuncionario
    {
        // Propriedades com acesso de leitura pública e escrita privada
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Cargo { get;  set; }
        public decimal Salario { get;  set; }

        // Construtor
        public Funcionario(string nome, string cpf, string endereco, string telefone, string cargo, decimal salario)
        {
            Nome = nome;
            CPF = cpf;
            Endereco = endereco;
            Telefone = telefone;
            Cargo = cargo;
            Salario = salario;
        }

        // Métodos
        public void Trabalhar()
        {
            Console.WriteLine($"{Nome} está trabalhando como {Cargo}.");
        }

        public void ReceberPagamento()
        {
            Console.WriteLine($"{Nome} recebeu o pagamento de {Salario:C}.");
        }
    }
}