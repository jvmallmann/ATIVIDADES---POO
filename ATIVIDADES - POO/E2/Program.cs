using ATIVIDADES___POO.E2.interfaces;
using ATIVIDADES___POO.E2;
class Program
{
    static void Main(string[] args)
    {
        var funcionarios = new List<IFuncionario>
        {
            new Funcionario("Louis C.", "12345444444", "Rua Baixada Mercado", "4912345678", "Recepcionista - 1", 3000),
            new Funcionario("Sandro C.", "12345444444", "Rua Baixada Mercado", "4912345678", "Porteiro", 3000),
            new Funcionario("Senna S.", "12345678999", "Rua Brasil Sander, 679", "4987654321", "Recepcionista - 2", 2000)
        };

        var clientes = new List<ICliente>
        {
            new Cliente("João Vitor M.", "123.456.789-00", "Rua João Kist, 1111", "4999999999"),
            new Cliente("Juliano H.", "999.999.999-00", "Avenida Brasil, 1323", "4999999999")
        };

        var quartos = new List<IQuarto>
        {
            new Quarto(101, "Solteiro", 150, true),
            new Quarto(102, "Casal", 200, true),
            new Quarto(103, "VIP", 500, false)
        };

        var reservas = new List<IReserva>
        {
            new Reserva(clientes[0], quartos[0], DateTime.Now, DateTime.Now.AddDays(2), funcionarios[0]),
            new Reserva(clientes[1], quartos[1], DateTime.Now, DateTime.Now.AddDays(3), funcionarios[2])
        };

        IHotel hotel = new Hotel("Hotel Do Mallmann", "Saudades - AVENIDA", quartos, reservas, funcionarios);

        hotel.ExibirInformacoes();
    }
}
