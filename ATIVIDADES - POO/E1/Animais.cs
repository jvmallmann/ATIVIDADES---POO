using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADES___POO.E1
{
    public class Animais
    {
        // Atributos
        private string _nome;
        private string _especie;



        // Propriedades
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string Especie
        {
            get { return _especie; }
            set { _especie = value; }
        }



        // Métodos
        public void Pular()
        {
            Console.WriteLine($"{_nome} esta pulando.");
        }



        // Assinaturas
        public void Respirar()
        {
            Console.WriteLine($"{_nome} está respirando.");
        }
        public bool Respirar(string nome)
        {
            return true;
        }



        // Método sobrecarga
        public virtual void EmitirSom()
        {
            Console.WriteLine($"{_nome} esta emitindo um som.");
        }



        // Método sobrescrita
        public virtual void Comer()
        {
            Console.WriteLine($"{_nome} esta comendo.");
        }



        // Construtor
        public Animais(string nome, string especie)
        {
            _nome = nome;
            _especie = especie;
        }



        // Classe filha (subclasse) Papagaio
        public class Papagaio : Animais
        {
            private string _corDasPenas;
            private int _idade;

            public string CorDasPenas
            {
                get { return _corDasPenas; }
                set { _corDasPenas = value; }
            }
            public int Idade
            {
                get { return _idade; }
                set { _idade = value; }
            }

            public void Voar()
            {
                Console.WriteLine($"{Nome} esta voando.");
            }



            // Construtor da subclasse
            public Papagaio(string nome, string especie, string corDasPenas, int idade) : base(nome, especie)
            {
                _corDasPenas = corDasPenas;
                _idade = idade;
            }



            // Sobrescrita de método
            public override void EmitirSom()
            {
                Console.WriteLine($"{Nome} esta imitando sons.");
            }

            public override void Comer()
            {
                Console.WriteLine($"{Nome} esta comendo frutas.");
            }
        }
    }
}

