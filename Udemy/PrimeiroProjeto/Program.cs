using PrimeiroProjeto;

Console.WriteLine("\n\nPOO C#\n\n");

var meuCarro = new Carro();
meuCarro.Modelo = "Jetta";
meuCarro.Cor = "Cinza";
meuCarro.Ano = 2022;
Console.WriteLine(meuCarro.Modelo + "\n" + meuCarro.Cor + "\n" + meuCarro.Ano);

meuCarro.LigarCarro();
Console.WriteLine("\n========================================================================\n");

Carro outroCarro = new Carro("Polo", "Preta", 2023);
Console.WriteLine(outroCarro.Modelo + "\n" + outroCarro.Cor + "\n" + outroCarro.Ano);

outroCarro.tocarBuzina();
Console.WriteLine("\n========================================================================\n");

var minhaMoto = new Moto();
minhaMoto.Marca = "BMW";
minhaMoto.Modelo = "F800";
minhaMoto.Cor = "Azul";
minhaMoto.Ano = 2022;
minhaMoto.Cilindradas = 800;

Console.WriteLine(minhaMoto.Marca + "\n" + minhaMoto.Modelo + "\n" + minhaMoto.Cor + "\n" + minhaMoto.Ano + "\n" + minhaMoto.Cilindradas);

outroCarro.tocarBuzina();
Console.WriteLine("\n========================================================================\n");

Moto outraMoto = new Moto("Honda", "XRE", "Verde", 2022, 300);
Console.WriteLine(outraMoto.Marca + "\n" + outraMoto.Modelo + "\n" + outraMoto.Cor + "\n" + outraMoto.Ano + "\n" + outraMoto.Cilindradas);
Console.WriteLine("\n========================================================================\n");

var pessoa = new Pessoa();
pessoa.Nome = "Victor";
pessoa.Sobrenome = " Hugo Borges França Souza";

Console.WriteLine("Primeiro nome: " + pessoa.Nome);
Console.WriteLine("Último nome: " + pessoa.Sobrenome);
Console.WriteLine("Nome e Sobrenome: " + pessoa.NomeCompleto);
Console.WriteLine("\n========================================================================\n");

var motorista = new Motorista();
motorista.Nome = "Calebe";
motorista.Sobrenome = "Cleiton";
motorista.Idade = 58;
motorista.CategoriaHabilitacao = "AD";

Console.WriteLine("Primeiro nome do motorista: " + motorista.Nome);
Console.WriteLine("Último nome do motorista: " + motorista.Sobrenome);
Console.WriteLine("Nome e Sobrenome do motorista: " + motorista.NomeCompleto);
Console.WriteLine("Categoria da Habilitação do motorista: " + motorista.CategoriaHabilitacao);
Console.WriteLine("\n========================================================================\n");





