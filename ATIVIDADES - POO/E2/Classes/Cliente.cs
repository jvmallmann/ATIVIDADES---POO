using ATIVIDADES___POO.E2.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADES___POO.E2.Classes
{
    public class Cliente : ICliente
    {
        // Propriedades públicas com encapsulamento
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        // Construtor para inicializar a classe
        public Cliente(string nome, string cpf, string email, string telefone)
        {
            Nome = nome;
            CPF = cpf;
            Email = email;
            Telefone = telefone;
        }

        // Método para exibir informações do cliente
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, CPF: {CPF}, Email: {Email}, Telefone: {Telefone}");
        }
    }
}