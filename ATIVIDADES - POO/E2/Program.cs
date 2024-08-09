using ATIVIDADES___POO.E2.interfaces;
using ATIVIDADES___POO.E2;

var funcionario1 = new Funcionario("Louis C.", "12345444444", "Rua Baixada Mercado", "4912345678", "Recepcionista - 2", 3000);

var funcionario3 = new Funcionario("Senna S.", "12345678999", "Rua Brasil Sander, 679", "4987654321", "Recepcionista - 2", 2000);

Cliente cliente1 = new Cliente("João Vitor M.", "123.456.789-00", "Rua joao kist, 1111", "4999999999");

Cliente cliente2 = new Cliente("Juliano H.", "999.999.999-00", "avenida brasil, 1323", "4999999999");

var quarto1 = new Quarto(101, "Solteiro", 150, true);
var quarto2 = new Quarto(102, "Casal", 200, true);

var reserva1 = new Reserva(cliente1, quarto1, DateTime.Now, DateTime.Now.AddDays(2), funcionario1);

var reserva2 = new Reserva(cliente2, quarto2, DateTime.Now, DateTime.Now.AddDays(3),funcionario3);

IHotel hotel = new Hotel("Hotel Do Mallmann", "Saudades - AVENIDA");

hotel.AdicionarQuarto(quarto1);

hotel.AdicionarQuarto(quarto2);

hotel.AdicionarReserva(reserva1);
hotel.AdicionarReserva(reserva2);

hotel.ExibirInformacoes();

