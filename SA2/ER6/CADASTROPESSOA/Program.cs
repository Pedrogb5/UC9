using CADASTROPESSOA.Classes;



Console.Clear();
Console.WriteLine(@$"

=============================================
|    Bem-vindo ao sistema de cadastro de    |
|       Pessoas Juridicas e Fisicas         |
=============================================


");

Utils.BarraCarregamento("Carregando");

string? resposta;

do
{
    Console.Clear();
    Console.WriteLine(@$"

=====================================
|               MENU                |
=====================================
|  (1) Cadastro de Pessoa Fisica    |
|  (2) Cadastro de Pessoa Juridica  |
|  (3) Sair                         |
=====================================

");

    Console.Write("Digite a opcao desejada: ");
    resposta = Console.ReadLine();

    switch (resposta)
    {
        case "1":

            PessoaFisica novaPf = new PessoaFisica(); // novaPf = novo objeto
            Endereco novoEndPf = new Endereco();

            novaPf.nome = "Pedro";
            novaPf.cpf = "18422288522";
            novaPf.rendimento = 6600;
            novaPf.dataNasc = new DateTime(2000, 1, 1); // deve ser criado uma instancia pois datetime e um metodo
            novoEndPf.logradouro = "Rua Querino Ary";
            novoEndPf.numero = 140;
            novoEndPf.complemento = "Perto de ....";
            novoEndPf.endComercial = true;
            novaPf.endereco = novoEndPf;
            float impostoPagar = novaPf.CalcularImposto(novaPf.rendimento);

            Console.Clear();

            Console.WriteLine(@$"
            Nome: {novaPf.nome}
            CPF: {novaPf.cpf}
            Endereco: {novaPf.endereco.logradouro} , {novaPf.endereco.numero}
            Maior de idade?: {novaPf.ValidarDataNasc(novaPf.dataNasc)}
            Total de imposto a pagar: {(impostoPagar.ToString("C"))} 
        
            "); // Todo metodo possui parametro (parenteses) .... a letra C como parametro no ToString transforma o ImpostoPagar em valor monetario

            Console.Write($"Aperte ENTER para continuar");
            Console.ReadLine();
            break;

        case "2":

            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

            novaPj.nome = "nome Pj";
            novaPj.razaoSocial = "Razao Social Pj";
            novaPj.cnpj = "33.222.444/0001-22";
            novaPj.rendimento = 6000.5f;

            novoEndPj.logradouro = "Rua Querino Ary";
            novoEndPj.numero = 130;
            novoEndPj.complemento = "complemento endereco";
            novoEndPj.endComercial = true;
            novaPj.endereco = novoEndPj;

            Console.Clear();

            Console.WriteLine(@$"
            Nome: {novaPj.nome}
            Razao Social: {novaPj.razaoSocial}
            CNPJ: {novaPj.cnpj} , Valido?: {novaPj.ValidarCnpj(novaPj.cnpj)}
            Rendimento: {(novaPj.rendimento.ToString("C"))}

            Endereco:
            Logradouro: {novaPj.endereco.logradouro}
            Numero: {novaPj.endereco.numero}
            Complemenento: {novaPj.endereco.complemento}
            Endereco comercial?: {novaPj.endereco.endComercial}
            
            ");

            Console.WriteLine($"Aperte ENTER para continuar");
            Console.ReadLine();
            break;

        case "3":

            Console.Clear();
            
            Console.WriteLine(@"Obrigado pela utilizacao do sistema
            ");

            Utils.BarraCarregamento("Saindo");
            break;

        default:

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Resposta do usuario invalida, digite novamente");
            Console.ResetColor();

            Thread.Sleep(3000);
            break;

    }

} while (resposta != "3");
















// Total de imposto a pagar: R${novaPf.CalcularImposto(novaPf.rendimento)}");



// 







// DateTime temp = new DateTime(2005, 05, 11);
// novaPf.ValidarDataNasc(temp);

//Console.WriteLine(novaPf.ValidarDataNasc("01/01/2000"));


