using ATIVIDADES___POO.E2.interfaces;
using System;

namespace ATIVIDADES___POO.E2
{
   public class Cliente : ICliente
    {
        public string Nome { get; set; }
        public string CPF{ get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public Cliente(string nome, string cpf, string endereco, string telefone)
        {
            Nome = nome;
            CPF = cpf;
            Endereco = endereco;
            Telefone = telefone;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, Documento: {CPF}, Endereço: {Endereco}, Telefone: {Telefone}");
        }
    }
}