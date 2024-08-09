using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADES___POO.E2.interfaces
{ 
public interface IFuncionario
    {
        string Cargo { get; set; }
        decimal Salario { get; set; }
        void ExibirInformacoes();
    }
}