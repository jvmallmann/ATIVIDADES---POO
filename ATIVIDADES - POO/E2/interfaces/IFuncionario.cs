using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADES___POO.E2.interfaces
{ 
public interface IFuncionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        string Cargo { get; set; }
        decimal Salario { get;  }
        void ExibirInformacoes();
    }
}