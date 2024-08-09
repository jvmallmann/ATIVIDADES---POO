using ATIVIDADES___POO.E2.interfaces;
using ATIVIDADES___POO.E2;
using ATIVIDADES___POO.E2.Classes;

Cliente cliente1 = new Cliente("João Vitor M.", "123.456.789-00", "Rua joao kist, 1111", "49999999999");

Cliente cliente2 = new Cliente("Juliano H.", "999.999.999-00", "avenida brasil, 1323", "49999999999");

IQuarto quarto1 = new Quarto(101, "Solteiro", 150,  true);

IQuarto quarto2 = new Quarto(102, "Casal", 200,  true);

IReserva reserva1 = new Reserva(1, cliente1, quarto1, DateTime.Now, DateTime.Now.AddDays(2));

IReserva reserva2 = new Reserva(2, cliente2, quarto2, DateTime.Now, DateTime.Now.AddDays(3));

IHotel hotel = new Hotel("Hotel Do Mallmann", "Saudades - AVENIDA");

hotel.AdicionarQuarto(quarto1);
hotel.AdicionarQuarto(quarto2);
hotel.AdicionarReserva(reserva1);
hotel.AdicionarReserva(reserva2);

hotel.ExibirInformacoes();

Console.ReadLine();