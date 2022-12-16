using CADASTROPESSOA.Classes;

PessoaFisica novaPf = new PessoaFisica(); // novaPf = novo objeto
Endereco novoEnd = new Endereco();

novaPf.nome = "Pedro";
novaPf.cpf = "18422288522";
novaPf.rendimento = 6600;
novaPf.dataNasc = new DateTime(2000, 1, 1); // deve ser criado uma instancia pois datetime e um metodo
novoEnd.logradouro = "Rua Querino Ary";
novoEnd.numero = 140;
novoEnd.complemento = "Perto de ....";
novoEnd.endComercial = true;
novaPf.endereco = novoEnd;

Console.WriteLine(@$"
Nome: {novaPf.nome}
CPF: {novaPf.cpf}
Endereco: {novaPf.endereco.logradouro} , {novaPf.endereco.numero}
Maior de idade?: {novaPf.ValidarDataNasc(novaPf.dataNasc)}
Total de imposto a pagar: R${novaPf.CalcularImposto(novaPf.rendimento)}

");

 
// float impostoPagar = novaPf.CalcularImposto(novaPf.rendimento);
// Console.WriteLine(impostoPagar.ToString("C")); // Todo metodo possui parametro (parenteses)

// PessoaJuridica novaPj = new PessoaJuridica();
// Console.WriteLine(novaPj.CalcularImposto(6600.5f));

// DateTime temp = new DateTime(2005, 05, 11);
// novaPf.ValidarDataNasc(temp);

//Console.WriteLine(novaPf.ValidarDataNasc("01/01/2000"));
