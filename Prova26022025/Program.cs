Console.WriteLine("CARRO");
Carros carro = new Carros();
carro._id = 1;
carro._descricao = "Descrição carro 1";
carro._marca = "Marca 1";
carro._anoFabricacao = "2009";
carro._valorDiaria = 100;
carro._portasQuant = 4;
carro._tamanhoBagageiro = 500;
carro.CalcularValorAluguel(8);

Console.WriteLine($"Valor total do aluguel: {carro._valorDiaria}");

Console.WriteLine("_____________________________");
Console.WriteLine("\nMOTO");
Motos moto = new Motos();
moto._id = 2;
moto._descricao = "Descrição moto 1";
moto._marca = "Marca 1";
moto._anoFabricacao = "2009";
moto._valorDiaria = 100;
moto._celindradas = 4;
moto._partidaEletrica = 500;
moto._peso = 1000;
moto._capTanque = 1000;
moto.CalcularValorAluguel(6);


Console.WriteLine($"Valor total do aluguel: {moto._valorDiaria}");
Console.WriteLine("_____________________________");


Console.WriteLine("\nCAMINHÃO");
Caminhoes caminhao = new Caminhoes();
caminhao._id = 3;
caminhao._descricao = "Descrição caminhão 1";
caminhao._marca = "Marca 1";
caminhao._anoFabricacao = "2009";
caminhao._valorDiaria = 100;
caminhao._quantEixos = 4;
caminhao._quantEixos = 10;
caminhao._capCarga = 1000;
caminhao._tipoCaroceria = "carga 1";
caminhao._comprimento = 1000;
caminhao._altura = 500;
caminhao.CalcularValorAluguel(20000);


Console.WriteLine($"Valor total do aluguel: {caminhao._valorDiaria}");
Console.WriteLine("_____________________________");


Console.WriteLine("\n ALUGUEL");
Aluguel aluguel  = new Aluguel();
aluguel._veiculo = carro;
aluguel._dataInicio = new DateOnly(2000, 02, 01);
aluguel._dataFinal = new DateOnly(2000, 02, 01); ;
aluguel._quantDias = 8;
aluguel._valorAluguel = 100;
aluguel.ValorTotalAluguel();

Console.WriteLine($"{aluguel._valorAluguel}");

