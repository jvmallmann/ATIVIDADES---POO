using System;

namespace ATIVIDADES___POO.E2.interfaces
{
    public interface ICliente
    {
        string Nome { get; set; }
        string CPF { get; set; }
        string Endereco { get; set; }
        string Telefone { get; set; }
    }
}
