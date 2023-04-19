using OrientacaoObjetos;
using OrientacaoObjetos.ClasseDerivada;

//Abstração
Computador novoComputador = new Computador();
string infos = novoComputador.Informacoes();
novoComputador.Descricao($"Esse {infos} é de ultima geração");
novoComputador.LigaDesliga(true);
novoComputador.name = infos;

//Encapsulamento
Person person = new Person("Leonardo", 29);
person.alterarInfos("José", 26);

//Herança
Leao leao = new Leao();
leao.Grupo = "Animais Selvagens";
leao.Acao();
leao.name = "Mufasa";

Tigre tigre = new Tigre();
tigre.Grupo = "Animais Selvagens";
tigre.Acao();
tigre.name = "Mike";

//Polimorfismo
Celular novoCelular = new Celular();
novoCelular.bateria = true;
novoCelular.estaLigado();
novoCelular.recarregar();
novoCelular.colocarCredito(10);



//Abstração
Console.WriteLine(infos);


//Encapsulamento
Console.WriteLine(person.Name);
Console.WriteLine(person.Age);

//Herança
Console.WriteLine($"O Leão se chama {leao.name}, pertence ao grupo dos {leao.Grupo}");
Console.WriteLine($"O Tigre se chama {tigre.name}, pertence ao grupo dos {tigre.Grupo}");

//Polimorfismo
Console.WriteLine($"O celular tem {novoCelular.colocarCredito} Reais de crédito");