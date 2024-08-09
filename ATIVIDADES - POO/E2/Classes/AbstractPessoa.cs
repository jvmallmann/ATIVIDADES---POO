using ATIVIDADES___POO.E2.interfaces;
using System;

namespace ATIVIDADES___POO.E2;
public abstract class AbstractPessoa : IPessoa
    {
        protected string _nome;
        protected string _cpf;
        protected string _endereco;
        protected string _telefone;

        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }

        public string CPF
        {
            get => _cpf;
            set => _cpf = value;
        }

        public string Endereco
        {
            get => _endereco;
            set => _endereco = value;
        }

        public string Telefone
        {
            get => _telefone;
            set => _telefone = value;
        }

        // Construtor
        protected AbstractPessoa(string nome, string cpf, string endereco, string telefone)
        {
            this._nome = nome;
            this._cpf = cpf;
            this._endereco = endereco;
            this._telefone = telefone;
        }
    }