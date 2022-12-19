using CADASTROPESSOA.Classes;

List<PessoaFisica> listaPf = new List<PessoaFisica>();

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


            string? respostaPf;
            do
            {

                Console.Clear();
                Console.WriteLine(@$"

=====================================
|              MENU (PF)            |
=====================================
|  (1) Cadastrar Pessoa Fisica      |
|  (2) Listar pessoa Fisica         |
|  (3) Voltar ao menu principal     |
=====================================

");

                Console.Write("Digite a opcao desejada: ");
                respostaPf = Console.ReadLine();

                switch (respostaPf)
                {
                    case "1":

                        PessoaFisica novaPf = new PessoaFisica(); // novaPf = novo objeto
                        Endereco novoEndPf = new Endereco();

                        Console.Write("Digite seu nome: ");
                        novaPf.nome = Console.ReadLine();


                        // bool dataValida;
                        // do
                        // {

                        //     Console.Write("Digite sua data de nascimento (Ex: DD/MM/AAAA): ");
                        //     string? dataNascimento = Console.ReadLine();
                        //     dataValida = novaPf.ValidarDataNasc(dataNascimento);

                        //     if (dataValida == false)
                        //     {

                        //         Console.ForegroundColor = ConsoleColor.Red;
                        //         Console.WriteLine($"Data de nascimento invalida, digite uma data valida");
                        //         Console.ResetColor();

                        //         Thread.Sleep(3000);


                        //     }
                        //     else
                        //     {
                        //         DateTime.TryParse(dataNascimento, out DateTime dataConvertida);

                        //         novaPf.dataNasc = dataConvertida;
                        //     }

                        // } while (!dataValida); //!dataValida = dataValida == false

                        // Console.Write("Digite seu CPF: ");
                        // novaPf.cpf = Console.ReadLine();

                        // Console.Write("Digite seu rendimento mensal (somente numeros): ");
                        // novaPf.rendimento = float.Parse(Console.ReadLine());

                        // Console.Write("Digite seu logradouro: ");
                        // novoEndPf.logradouro = Console.ReadLine();

                        // Console.Write("Digite seu numero: ");
                        // novoEndPf.numero = int.Parse(Console.ReadLine());

                        // Console.Write("Digite um complemento: ");
                        // novoEndPf.complemento = Console.ReadLine();


                        // Console.Write("O endereco e comercial? (S/N): ");
                        // string respostaend = Console.ReadLine().ToUpper();

                        // if (respostaend == "S")
                        // {
                        //     novoEndPf.endComercial = true;
                        // }
                        // else
                        // {
                        //     novoEndPf.endComercial = false;
                        // }

                        //novaPf.endereco = novoEndPf;

                        // listaPf.Add(novaPf);
                        
                        
                       
                        // sw.Close();

                        using (StreamWriter sw = new StreamWriter($"{novaPf.nome}.txt")) // using subtitui o sw.close
                        {
                             sw.WriteLine(novaPf.nome);
                        }

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro realizado com sucesso");
                        Console.ResetColor();
                        Thread.Sleep(3000);

                        break;

                    case "2":

                        Console.Clear();

//                         if (listaPf.Count > 0)
//                         {
//                             foreach (PessoaFisica cadaPf in listaPf) // para cada pessoafisica em lista
//                             {
//                                 Console.WriteLine(@$"
// Nome: {cadaPf.nome}
// CPF: {cadaPf.cpf}
// Endereco: {cadaPf.endereco.logradouro} , {cadaPf.endereco.numero}
// Data de nascimento: {cadaPf.dataNasc.ToString("d")} 
// Total de imposto a pagar: {cadaPf.CalcularImposto(cadaPf.rendimento).ToString("C")} // ToString('C') = converte para valor monetario

// "); 

//                                 Console.Write($"Aperte ENTER para continuar");
//                                 Console.ReadLine();
//                             }

//                         }
//                         else
//                         {
//                             Console.WriteLine("Lista vazia");
//                             Thread.Sleep(2000);
//                         }

                        using (StreamReader sr = new StreamReader("Pedro.txt"))
                        {
                            string? linha;

                            while ((linha = sr.ReadLine()) != null) // enquanto tiver algo para ler faca writeline
                            {
                                Console.WriteLine($"{linha}");
                            }

                        }


                        Console.Write($"Aperte ENTER para continuar");
                        Console.ReadLine();

                        break;

                    case "3":

                        Utils.BarraCarregamento("Voltando");

                        break;

                    default:

                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Resposta do usuario invalida, digite novamente");
                        Console.ResetColor();

                        Thread.Sleep(3000);

                        break;
                }


            } while (respostaPf != "3");



            break;

        case "2":

            PessoaJuridica metodosPj = new PessoaJuridica();
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

            // Console.WriteLine(@$"
            // Nome: {novaPj.nome}
            // Razao Social: {novaPj.razaoSocial}
            // CNPJ: {novaPj.cnpj} , Valido?: {(novaPj.ValidarCnpj(novaPj.cnpj) ? "Sim" : "Nao")} 
            // Rendimento: {(novaPj.rendimento.ToString("C"))}

            // Endereco:
            // Logradouro: {novaPj.endereco.logradouro}
            // Numero: {novaPj.endereco.numero}
            // Complemenento: {novaPj.endereco.complemento}
            // Endereco comercial?: {(novaPj.endereco.endComercial  ? "Sim" : "Nao")}
            
            // "); // if ternario ... condicao ?(true) resposta :(else) resposta

            metodosPj.Inserir(novaPj);

            List<PessoaJuridica> listaExibicaoPj = metodosPj.LerArquivos();

            foreach (PessoaJuridica cadaItem in listaExibicaoPj)
            {

                Console.Clear();
                
            Console.WriteLine(@$"
            Nome: {cadaItem.nome}
            Razao Social: {cadaItem.razaoSocial}
            CNPJ: {cadaItem.cnpj} , Valido?: {(cadaItem.ValidarCnpj(cadaItem.cnpj) ? "Sim" : "Nao")}
            ");

                Console.WriteLine($"Aperte ENTER para continuar");
                Console.ReadLine();

            }


            
            break ;
            

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


