using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADES___POO.E2.interfaces
{
    public interface IReserva
    {
        ICliente Cliente { get; set; }
        IQuarto Quarto { get; set; }
        DateTime DataCheckIn { get; set; }
        DateTime DataCheckOut { get; set; }
        IFuncionario Recepcionista { get; set; }

        decimal CalcularValorTotal();
        void ExibirInformacoes();
    }
}
