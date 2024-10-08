﻿using ATIVIDADES___POO.E2.interfaces;
using System;

namespace ATIVIDADES___POO.E2
{
    public class Quarto : IQuarto
    {
        public int Numero { get; set; }
        public string Tipo { get; set; }
        public decimal PrecoBase { get; set; }
        public bool Disponivel { get; set; }

        public Quarto(int numero, string tipo, decimal precoBase, bool disponivel)
        {
            Numero = numero;
            Tipo = tipo;
            PrecoBase = precoBase;
            Disponivel = disponivel;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Número: {Numero}, Tipo: {Tipo}, Preço Base: {PrecoBase:C}, Disponível: {(Disponivel ? "Sim" : "Não")}");
        }
    }
}
