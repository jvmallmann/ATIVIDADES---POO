using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADES___POO.E2.interfaces
{
    public interface IHotel
    {
        string Nome { get; set; }
        string Endereco { get; set; }
        List<IQuarto> Quartos { get; set; }
        List<IReserva> Reservas { get; set; }

        void AdicionarQuarto(IQuarto quarto);
        void AdicionarReserva(IReserva reserva);
        void ExibirInformacoes();
    }
}
