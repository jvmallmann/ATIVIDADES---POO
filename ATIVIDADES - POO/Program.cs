using ATIVIDADES___POO.E1;

Animais.Papagaio meuPapagaio = new Animais.Papagaio("Loro", "Amazona aestiva", "Verde", 2);

Console.WriteLine($"{meuPapagaio.Nome}, um {meuPapagaio.Especie}, com penas {meuPapagaio.CorDasPenas}.");
meuPapagaio.EmitirSom();
meuPapagaio.Comer();
meuPapagaio.Voar();
