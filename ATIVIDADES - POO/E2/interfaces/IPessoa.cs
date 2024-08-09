using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADES___POO.E2.interfaces
{
    public interface IPessoa
    {
        string Nome { get; set; }
        string CPF { get; set; }
        string Endereco { get; set; }   
        string Telefone { get; set; }
    }
}
