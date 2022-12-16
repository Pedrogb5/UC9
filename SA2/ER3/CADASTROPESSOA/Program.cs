using CADASTROPESSOA.Classes;

PessoaFisica novaPf = new PessoaFisica(); // novaPf = novo objeto

novaPf.nome = "Pedro";
novaPf.rendimento = 6600;
 
float impostoPagar = novaPf.CalcularImposto(novaPf.rendimento);
Console.WriteLine(impostoPagar.ToString("C")); // Todo metodo possui parametro (parenteses)

PessoaJuridica novaPj = new PessoaJuridica();
Console.WriteLine(novaPj.CalcularImposto(6600.5f));