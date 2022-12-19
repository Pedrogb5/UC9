# Título e descrição

Sistema de Cadastro de Pessoas Fisicas e Juridicas

# Features (funcionalidades)

* Cadastra uma Pessoa Fisica com informacoes do usuario: nome, cpf, data de nascimento, rendimento, endereco etc.
* Valida a eligibilidade da data de nascimento (deve possuir no minimo 18 anos).
* Lista o numero de Pessoas Fisicas e respectivos dados cadastrais.
* Cadastra uma Pessoa Juridica com informacoes como nome, cnpj, razao social, endereco etc.
* Verifica a elegibilidade do cnpj.
* Calcula taxa de imposto de acordo com o rendimento do usuario.
* Armazena os dados cadastrais de cada usuario em um banco de dados tipo csv

# Tecnologias utilizadas

* C#
* Visual Studio Code

# Organização do projeto

* Criar o projeto dotnet, criar interfaces e classes de pessoa física e jurídica, que herdaram de uma classe principal, Pessoa
* Criar funcao de calcular taxa imposto (taxa se difere de acordo com o tipo de pessoa)
* Criar classe endereco e seus atributos(logradouro, numero, complemento etc.), que sera utilizada por ambas as pessoas 
* Na classe Pessoa Fisica, criar metodo de validacao de data de nascimento
* Na classe Pessoa Juridica, criar metodo de validacao de cnpj
* Criar no arquivo Program uma interface de menu para o usuario
* Armazenar informacoes do cadastro de pessoas fisicas e juridicas em arquivos txt e csv respectivamente

# Pré-requisitos de instalação

* Espaço em disco - 1GB

# Execução da aplicação

* Instalar Vscode
* Baixar o projeto
* Abrir no Vscode o projeto
* Abrir o terminal
* Executar o program com o comando dotnet run

# Erros comuns

* Ambos CPF e CNPJ nao precisam existir realmente para serem adicionados nos dados cadastrais 
* Deve-se fazer o cadastro ate o fim, nao podendo ser parcialmente

# Contribuidores

* Instituicao SENAI
* Pedro Gomes
